using System;
using System.Collections.Generic;

namespace Yakky
{
    //The main emphasis in this exercise is SendMyEmails method and thats it
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

        public bool SendMyEmails(BrandNewSettings bns, List<Email> myEmails, bool submit) {
            try {
                foreach(var p in myEmails) {
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