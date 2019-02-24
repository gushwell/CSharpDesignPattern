using System;
using System.Linq;
using System.Collections.Generic;

namespace Gushwell.Design.Patterns {

    public class ProbStrategy : IStrategy {
        private Random random;
        private Hand PrevHandValue { get; set; } = Hand.GUU;
        private Hand CurrentHandValue { get; set; } = Hand.GUU;

        private int[][] _history = new int[][] { new int[] { 1, 1, 1 }, 
                                                new int[] { 1, 1, 1 }, 
                                                new int[] { 1, 1, 1 } };

        public ProbStrategy(int seed) {
            random = new Random(seed);
            foreach (var hv1 in Hand.GetValues())
                foreach (var hv2 in Hand.GetValues())
                    _history[hv1][hv2] = 1;
        }

        public Hand NextHand() {
            var bet = random.Next(GetSum(CurrentHandValue));
            var handvalue = Hand.GUU;
            if (bet < _history[CurrentHandValue][Hand.GUU]) {
                handvalue = Hand.GUU;
            } else if (bet < _history[CurrentHandValue][Hand.GUU] + _history[CurrentHandValue][Hand.CHO]) {
                handvalue = Hand.CHO;
            } else {
                handvalue = Hand.PAA;
            }
            PrevHandValue = CurrentHandValue;
            CurrentHandValue = handvalue;
            return new Hand(handvalue);
        }

        private int GetSum(Hand hv) {
            return _history[hv].Sum();
        }

        public void Study(bool win) {
            if (win) {
                _history[PrevHandValue][CurrentHandValue]++;
            } else {
                _history[PrevHandValue][CurrentHandValue.NextHand()]++;
                _history[PrevHandValue][CurrentHandValue.NextHand().NextHand()]++;
            }
        }
    }
}