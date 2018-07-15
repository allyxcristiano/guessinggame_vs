using GuessingGame.implementation;
using GuessingGame.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public class Runner
    {
        internal void Start()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(livesInWater, new Animal("monkey"));
            Node firstChildNode = new Node(null, new Animal("shark"));
            livesInWater.NodeForSpecializatedTrait = firstChildNode;

            IGuessingGameMessages questionMessageBox = new GuessingGameMessagesDialog();
            GuessingGameService guessingGameService = new GuessingGameService(questionMessageBox);

            while (guessingGameService.startGame())
            {
                guessingGameService.doQuestion(root);
            }
        }
    }
}
