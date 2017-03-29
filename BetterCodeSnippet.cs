using System;
using System.Collections.Generic;

namespace Yakky.Better
{
    public class BrandNewSettings {

    }
    public class Email {

    }
    
    public class ResultInfo {
        public Dictionary<string, string> Messages {get; set;}
        public bool IsSuccess {get; set;}
    }

    public class SpecialCodeSnippet
    {

        //When I name my method SendMyEmails I expect it to do that, all I see here it is 
        //calling another method to call to call myEmails
        //What is this method doing?

        //Variable name bns is a bad naming convention
        //bns maybe means something at the top of the method but once you drill down if you have
        //500 lines of code which too littel for us then bns becomes very vague
        //How about brandNewSettings?
        public bool SendMyEmails(BrandNewSettings bns, List<Email> myEmails, bool submit) {

            //What is the point of the Try and Catch here?
            //If you are not doing anything when catching an exception why are you hidding it
            try {

                //We have here a Foreach, why?
                //Once this method finish it will returns
                //It is very confusing and doing an unexpected behavoir
                foreach(var p in myEmails) {
                    //This is returning a result info, why?
                    //We dont bother checking what the message is
                    //Why is this method returning a class and it only uses the boolean value
                    //Maybe it should return a boolean only?
                    //Maybe we should call another method?
                    var ri = SomehowSendMyEmails();

                    return ri.IsSuccess;
                }
            } catch(Exception) {}

            return false;
        }

        public ResultInfo SomehowSendMyEmails() {
            return new ResultInfo();
        }
    }
}