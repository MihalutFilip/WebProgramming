using AjaxLabServerSide.Context;
using AjaxLabServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Repository
{
    public class Xand0Repository
    {
        public List<Xand0> GetXAnd0()
        {
            var Xand0s = new List<Xand0>();
            using (var context = new AjaxContext())
            {
                Xand0s = context.Xand0s.ToList();
            }

            return Xand0s;
        }
        
        private bool HaveSameValue(string s1, string s2, string s3)
        {
            return s1 == s2 && s1 == s3 && s2 == s3 && s1 != null;
        }

        private string VerifyIfSomeoneWin(List<Xand0> xand0)
        {
            //TODO : This must be also in a service

            // line 
            for (int i = 0; i < 9; i += 3)
                if (HaveSameValue(xand0[i].Value, xand0[i + 1].Value, xand0[i + 2].Value))
                    return xand0[i].Value;

            //column
            for (int i = 0; i < 3; i++)
                if (HaveSameValue(xand0[i].Value, xand0[3 + i].Value, xand0[6 + i].Value))
                    return xand0[i].Value;

            //diagonal
            if (HaveSameValue(xand0[0].Value, xand0[4].Value, xand0[8].Value) || HaveSameValue(xand0[2].Value, xand0[4].Value, xand0[6].Value))
                return xand0[4].Value;

            return null;
        }

        public Xand0 SaveNextMove(int id)
        {
            using (var context = new AjaxContext())
            {
                //save move for X
                var xand0 = context.Xand0s.FirstOrDefault(x => x.Id == id);
                xand0.Value = "X";
                context.SaveChanges();

                //check
                var value = VerifyIfSomeoneWin(context.Xand0s.ToList());
                if (value != null)
                    return new Xand0() { Value = value };
                else if(context.Xand0s.Count(x => x.Value == null) == 0)
                    return new Xand0() { Value = "X 0" };

                //save randomly move for 0
                //TODO: Service for this
                int idFor0;
                Random random = new Random();
                
                do
                {
                    idFor0 = random.Next(1, 10);
                } while (context.Xand0s.FirstOrDefault(x => x.Id == idFor0).Value != null);

                xand0 = context.Xand0s.FirstOrDefault(x => x.Id == idFor0);
                xand0.Value = "0";
                context.SaveChanges();

                //check
                value = VerifyIfSomeoneWin(context.Xand0s.ToList());
                if (value != null)
                    return new Xand0() { Value = value };
                else
                    return xand0;
            }
        }
    }
}