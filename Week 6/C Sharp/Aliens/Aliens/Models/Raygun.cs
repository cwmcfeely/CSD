using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aliens.Models
{
    public class Raygun
    {
        // Properties
        
        //The maximum charge the Raygun can hold
        public int MaxCharge { get; set; }

        //The current level of charge the Raygun has
        public int CurrentCharge { get; set; }

        public Raygun(int mChrg, int cChrg)
        {
         
            MaxCharge = mChrg; 
            CurrentCharge = cChrg; 

            
            if (CurrentCharge > MaxCharge)
            {
                CurrentCharge = MaxCharge;
            }
        }

        

        // Methods
        //TODO: Implement appropriate getters and setters for the class

        public void FireAt(Alien a)
        {
            //TODO: Implement the method
            /*The gun should only fire if it is charged. Firing the gun will reduce the charge by 1. If the alien isDodging
            * alien.miss() should be called, otherwise alien.hit */

        }

        public void Recharge()
        {
            //TODO: Implement the method
            /*Increases the current charge by 1*/
        }

        public bool IsCharged()
        {
            return CurrentCharge > 0;
            /*Returns true if the gun has a charge*/

        }

        public bool IsFullyCharged()
        {
            return CurrentCharge == MaxCharge;
            /*Returns true if the gun is fully charged*/
        }


    }
}
