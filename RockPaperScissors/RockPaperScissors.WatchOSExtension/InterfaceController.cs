using System;
using System.Diagnostics;
using Foundation;
using UIKit;
using WatchKit;

namespace RockPaperScissors.WatchOSExtension
{
    public partial class InterfaceController : WKInterfaceController
    {
        private enum Results { EMPATE, VITORIA, PERDEU };
        private enum Moves { Rock, Paper, Scissors }
        private Moves[] Options = { Moves.Rock, Moves.Paper, Moves.Scissors };

        protected InterfaceController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine("{0} awake with context", this);
        }

        public override void WillActivate()
        {

            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine("{0} will activate", this);
        }

        partial void CommandScissors()
        {
            CheckMoves(Moves.Scissors);
            ButtonScissors.SetBackgroundColor(UIColor.Purple);
        }

        partial void CommandRock()
        {
            CheckMoves(Moves.Rock);
            ButtonRock.SetBackgroundColor(UIColor.Purple);
        }

        partial void CommandPaper()
        {
            CheckMoves(Moves.Paper);
            ButtonPaper.SetBackgroundColor(UIColor.Purple);
        }

        private void CheckMoves(Moves moveSelect)
        {

            ResetValues();

            var random = new Random();

            var position = random.Next(0, Options.Length);
            var machineChoose = Options[position];

            Debug.WriteLine("Computador escolheu: " + machineChoose);

            if(machineChoose == moveSelect)
            {
                LabelResult.SetTextColor(UIColor.Orange);
                LabelResult.SetText(Results.EMPATE.ToString());
            }
            else if (moveSelect == Moves.Rock && machineChoose == Moves.Scissors)
            {
                ButtonScissors.SetBackgroundColor(UIColor.Orange);
                LabelResult.SetText(Results.VITORIA.ToString());
            }
            else if (moveSelect == Moves.Scissors && machineChoose == Moves.Paper)
            {
                ButtonPaper.SetBackgroundColor(UIColor.Orange);
                LabelResult.SetText(Results.VITORIA.ToString());
            }
            else if (moveSelect == Moves.Paper && machineChoose == Moves.Rock)
            {
                ButtonRock.SetBackgroundColor(UIColor.Orange);
                LabelResult.SetText(Results.VITORIA.ToString());
            }
            else
            {
                if(machineChoose == Moves.Rock)
                    ButtonRock.SetBackgroundColor(UIColor.Orange);
                else if (machineChoose == Moves.Scissors)
                    ButtonScissors.SetBackgroundColor(UIColor.Orange);
                else
                    ButtonPaper.SetBackgroundColor(UIColor.Orange);

                //  resultado
                LabelResult.SetTextColor(UIColor.Red);
                LabelResult.SetText(Results.PERDEU.ToString());
            }

        }

        private void ResetValues()
        {
            LabelResult.SetText("");
            ButtonScissors.SetBackgroundColor(UIColor.White);
            ButtonRock.SetBackgroundColor(UIColor.White);
            ButtonPaper.SetBackgroundColor(UIColor.White);
            LabelResult.SetTextColor(UIColor.Blue);
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine("{0} did deactivate", this);
        }
    }
}

