using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302213102
{
    internal class PosisiKarakterGame
    {
        public enum state { Tengkurap, Jongkok, Berdiri, Terbang };
        public enum trigger { TombolW, TombolS, TombolX };

        public state currentState = state.Berdiri;
        public class Transition
        {
            public state stateAwal;
            public state stateAkhir;
            public trigger trig;

            public Transition(state sAwal, state sAkhir, trigger trigg)
            {
                stateAwal = sAwal;
                stateAkhir = sAkhir;
                trig = trigg;
            }
        }
        Transition[] transisi =
        {
            new Transition(state.Tengkurap, state.Jongkok, trigger.TombolW),
            new Transition(state.Jongkok, state.Tengkurap, trigger.TombolS),
            new Transition(state.Jongkok, state.Berdiri, trigger.TombolW),
            new Transition(state.Berdiri, state.Jongkok, trigger.TombolS),
            new Transition(state.Berdiri, state.Terbang, trigger.TombolW),
            new Transition(state.Terbang, state.Jongkok, trigger.TombolX),
            new Transition(state.Terbang, state.Berdiri, trigger.TombolS),
        };
        private state GetStateBerikutnya(state stateAwal, trigger trigger)
        {
            state stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trig)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }
        public void ActivateTrigger(trigger Trigger)
        {
            currentState = GetStateBerikutnya(currentState, Trigger);
        }
    }
}
