using System;
using System.Collections.Generic;

namespace Yakky.AnotherSnippet
{
    //The main emphasis in this exercise is SomehowSendMyEmails method and thats it
    public class NewObject{} 
    public class BrandNewSettings{}
    public class Email {}

    public class ResultInfo
    {
        public Dictionary<string, string> Messages { get; set; }
        public bool IsSuccess { get; set; }
        public bool IsMyEmailValid { get; set; }
        public string Message { get; set; }
    }

    public class SpecialCodeSnippet
    {
        public ResultInfo SomehowSendMyEmails()
        {
            ResultInfo ri = new ResultInfo();
            ri.Messages = new Dictionary<string, string>();
            try
            {
                NewObject no = new NewObject();
                BrandNewSettings bns = GoGetMeSettings();
                //This will only get temporary settings
                //Run some validation before you run anything
                // Save some file at some location
                var emailValidation = ValidateMyEmail(); //Validates a given email.

                if (emailValidation)
                {
                    ri.IsMyEmailValid = true;
                    ri.Messages.Add("EmailValidation", "Email validate success");
                }
                else
                {
                    ri.Messages.Add("EmailValidation", "Email validate Fail");
                }

                //We did something here called some more methods 
                var someResult = true;
                ri.Messages.Add("MoreMessaging", "Some Text: " + someResult + " !!!!! ");
                if (someResult)
                {
                    //Do bunch Stuff
                    ri.Messages.Add("More Messaging", "Yo I worked");
                    ri.IsSuccess = true;
                    ri.Message = "Get County Tax Success";
                }
                else
                {
                    ri.Messages.Add("Oh No", "reasons we failed");
                    ri.Message = "Damn it I failed";
                }
                //Blah Blah
                //Some Code that I am not using any more
                //Some comments about the code I am not using any more
                //More Code
                //Blah Blah
            }
            catch (Exception ex)
            {
                ri.Message = "Ops an exception happened " + ex.Message;
            }
            finally
            {
                //Console.WriteLine("Yay I hit the Finally and it seems everything is working");
            }
            return ri; ;
        }

        public bool SendMyEmails(BrandNewSettings bns, List<Email> myEmails, bool submit)
        {
            try
            {
                foreach (var p in myEmails)
                {
                    var ri = SomehowSendMyEmails();
                    return ri.IsSuccess;
                }
            }
            catch (Exception) { }

            return false;
        }

        public BrandNewSettings GoGetMeSettings() { return new BrandNewSettings(); }
        public bool ValidateMyEmail() { return false; }
    }
}