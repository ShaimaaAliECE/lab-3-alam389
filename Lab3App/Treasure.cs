using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public virtual void UpdateTotalValue() { } 

        public virtual void UpdateTotalScore() { }

       public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            list.Add(this);
            UpdateTotalScore();
            
        }
       
    }
}
