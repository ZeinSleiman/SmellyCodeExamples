using System;
using System.Collections.Generic;

namespace Yakky.AnotherSnippet.Better
{
    //The main emphasis in this exercise is SomehowSendMyEmails method and thats it
    public class NewObject{} //This is new
    public class BrandNewSettings{}
    public class Email {}

    public class ResultInfo
    {
        public Dictionary<string, string> Messages { get; set; }
        public bool IsSuccess { get; set; }

        //This is new
        public bool IsMyEmailValid { get; set; }

        //This is new
        public string Message { get; set; }
    }

    public class SpecialCodeSnippet
    {
        public ResultInfo SomehowSendMyEmails()
        {
            ResultInfo ri = new ResultInfo();
            ri.Messages = new Dictionary<string, string>();

            /*Again we notice a pattern, Wrap everything in a try catch
            Lets see the catch, is it the same as last time?*/
            try
            {

                /*Another bad naming convetion
                Use Var no need to repeat*/
                NewObject no = new NewObject();
                BrandNewSettings bns = GoGetMeSettings();

                /*Wait what is all this comments? Do I really need them?
                No delete them, because if you dont the developer after you
                will waste time reading them to understand
                you want him to follow a documentation -> Maybe put the link in the top of the class?
                Write a confluence page about this?*/

                //This will only get temporary settings
                //Run some validation before you run anything
                // Save some file at some location


                /*The comment here is completely useless, the name of the function 
                Tells me all about what the method does*/
                var emailValidation = ValidateMyEmail(); //Validates a given email.

                if (emailValidation)
                {
                    /*Very interesting, this tells you whether the email is valid
                    but in the calling method we dont care? Why is that?
                    More messages*/
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
                    /*Again more messages and the new here is the message by itself*/
                    /*Another method is definitely calling this because all these messages must mean something
                    Guess what? Out of 3 calls one is checking ri.Message. */ 
                    
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
                //We at least It is checking the exception and adding it in the Messages
                //Hold on Hold on -  Lets go back to the calling method
                ri.Message = "Ops an exception happened " + ex.Message;
            }
            finally
            {
                /* Do you know how many Console.WriteLine we have in the system? 63 Occassion
                How many should we have 0. When you delete this comment, finally is useless.
                Nothing wrong with testing and using whatever makes your life easier but when you are 
                done clean after yourself.
                 */
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
                    //If this is completely wrapped in an exception 
                    //Then why we have a try catch here?
                    //We got an exception, What is the messaege, Went into a black hole
                    //Client complains -> We debug to figure out -> We lose time
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