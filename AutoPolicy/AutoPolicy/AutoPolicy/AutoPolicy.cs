
/// <summary>
/// Class that represents an auto insurance policy.
/// </summary>
class AutoPolicy
{
   public int AccountNumber { get; set; } // policy account number
   public string MakeAndModel { get; set; } // car that policy applies to
   public string State { get; set; } // two-letter state abbreviation

    
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="accountNumber"></param>
    /// <param name="makeAndModel"></param>
    /// <param name="state"></param>
    public AutoPolicy(int accountNumber, string makeAndModel, string state)
   {
      AccountNumber = accountNumber;
      MakeAndModel = makeAndModel;
      State = state;
   }

    /// <summary>
    /// returns whether the state has no-fault insurance
    /// </summary>

    public bool IsNoFaultState 
    {
        get
        {
            bool noFaultState;

            // determine whether state has no-fault auto insurance           
            //switch (State) // get AutoPolicy object's state abbreviation
            //{
            //    case "MA":
            //    case "NJ":
            //    case "NY":
            //    case "PA":
            //        noFaultState = true;
            //        break;
            //    default:
            //        noFaultState = false;
            //        break;
            //}
            //return noFaultState;

            State switch
            {
                "MA" => ,
                "NJ" => ,
                "NY" => ,
                "PA" => noFaultState = true,
                _=> noFaultState = false

            };

            return noFaultState; 
        }
    }



}
