using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachineWinForms
{
    public partial class Form1 : Form
    {
        private SlotMachineGame _game;

        private Dictionary<Symbol, string> symbolToFilename = new Dictionary<Symbol, string>
        {
            [Symbol.Banana] = "banana.jpg",
            [Symbol.BigWin] = "bigwin.jpg",
            [Symbol.Cherry] = "cherry.jpg",
            [Symbol.Grape] = "grape.jpg",
            [Symbol.Lemon] = "lemon.jpg",
            [Symbol.Orange] = "orange.jpg",
            [Symbol.Seven] = "seven.jpg",
            [Symbol.ThreeBars] = "threebars.jpg",
            [Symbol.Watermelon] = "watermelon.jpg",
            [Symbol.Empty] = null
        }; 
        public Form1()
        {
            InitializeComponent();
            _game = new SlotMachineGame();

            Task.Run(InitGame);
            
        }

        private async Task InitGame()
        {
            UpdateTextBoxes();
            await UpdatePictureBoxImages();
        }

        private void PlaySound(string soundFileName)
        {
            using (var soundPlayer = new SoundPlayer())
            {
                soundPlayer.SoundLocation = $"Sounds\\{soundFileName}";
                soundPlayer.Play();
            }
        }

        private void UpdateTextBoxes()
        {
            playerCreditLbl.Text = _game.PlayerCredit.ToString();
            bettingAmountTxt.Clear();
        }

        private async Task UpdatePictureBoxImages()
        {
            if (_game.Slots.All(x => x == Symbol.BigWin))
                await Task.Delay(1000);

            PictureBox[] slotsPboxes = { slot1Pbox, slot2Pbox, slot3Pbox };

            for(int i = 0;i < 3;i++)
            {
                var slotSymbol = _game.Slots[i];
                if(slotSymbol == Symbol.Empty) continue;
                var pictureBox = slotsPboxes[i];
                var imageName = symbolToFilename[slotSymbol];
                pictureBox.Image = Image.FromFile($"Images\\{imageName}");
            }
        }

        private async void SpinBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(bettingAmountTxt.Text, out int bettingAmount)) return;
            _game.CurrentBet = bettingAmount;
            PlaySound("InsertCoin.wav");
            PlaySound("LeverPull.wav");
            UpdateTextBoxes();
            await MakeAnimation();
            _game.Spin();
            PlaySoundIfHasWonAnyAmount();
            await UpdatePictureBoxImages();
            UpdateTextBoxes();
        }

        private void PlaySoundIfHasWonAnyAmount()
        {

            // haven't updated player credit label so it contains the  credit before spin
            if (_game.PlayerCredit > int.Parse(playerCreditLbl.Text)) // if player credit after spin is better than last
                PlaySound("PayoutSound.wav");
        }

        private async Task  MakeAnimation()
        {
            var symbols = symbolToFilename.Keys.ToArray();

            for (int i = 0; i < 20; i++)
            {
                symbols = symbols.Shuffled();
                _game.Slots = symbols.Take(3).ToArray();
                await Task.Delay(100);
                await UpdatePictureBoxImages();
            }
        }
    }

    public class SlotMachineGame
    {
        public int PlayerCredit { get; set; } = 200;

        public int CurrentBet
        {
            get => _currentBet;
            set
            {
                _currentBet = value;
                PlayerCredit -= value;
            }
        }

        public Symbol[] Slots { get; set; }

        private readonly Symbol[] _symbols;
        private int _currentBet;

        public SlotMachineGame()
        {
            Slots = Enumerable.Repeat(Symbol.Empty,3).ToArray();
            _symbols = Enum.GetValues(typeof(Symbol))
                           .Cast<Symbol>()
                           .Except(new []{Symbol.Empty,Symbol.BigWin})
                           .ToArray();
        }

        public void Spin()
        {
            Slots = new[]
            {
                _symbols.Shuffled().First(),
                _symbols.Shuffled().First(),
                _symbols.Shuffled().First()
            };

            UpdateGameFunds();
        }

        private void UpdateGameFunds()
        {
            int winAmount = CalculateWinAmount();

            CurrentBet = 0;
            PlayerCredit += winAmount;
        }

        private int CalculateWinAmount()
        { 
            bool AtLeastOneSeven() => Slots.Any(s => s == Symbol.Seven);

            bool IsPair() => Slots.Distinct().Count() == 2;

            bool IsThreeOfAKind() => Slots.Distinct().Count() == 1;


            if (IsThreeOfAKind())
            {
                Slots = Enumerable.Repeat(Symbol.BigWin, 3).ToArray();
                return 7 * CurrentBet;
            }
            else if (IsPair())
            {
                return 2 * CurrentBet;
            }
            else if (AtLeastOneSeven()) return CurrentBet;
            else return 0;
        }
    }

    public enum Symbol
    {
        Lemon, Banana, Cherry, ThreeBars, Orange, Grape, Seven, Watermelon,
        BigWin, Empty
    }

    public static class HelperExtensions
    {
        static readonly Random rand = new Random();
        public static T[] Shuffled<T>(this T[] array)
        {
            var copy = new T[array.Length];
            array.CopyTo(copy,0);
            
            for (int i = 0; i < array.Length; i++)
            {
                int j = rand.Next(i + 1);
                (copy[i], copy[j]) = (copy[j], copy[i]);
            }

            return copy;
        }
    }
}
