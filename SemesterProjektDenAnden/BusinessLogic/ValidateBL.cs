using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class ValidateBL
    {
        public static async Task<bool> Validator(string type, string optionalstr = "default string",
            int optionalint = 10, Client optionalClient = null)
        {
            switch (type)
            { case "string": 
                    if (optionalstr == "default string") { return false; }
                    else await ValidateString(optionalstr); break;

              case "int": 
                    if (optionalint == 10) { return false; }
                    else await ValidateInt(optionalint); break;

              case "Client": 
                    if (optionalClient == null) { return false; }
                    else await ValidateClient(optionalClient); break;

              
            }
            return true;
        }

        private static async Task<bool> ValidateClient(Client optionalClient)
        {
            
            ValidateString(optionalClient.FirstName);
            ValidateString(optionalClient.LastName);
            ValidateInt(optionalClient.Phone);
            ValidateString(optionalClient.Mail);
            ValidateString(optionalClient.ClAddress);
            
            
            return true;
        }

        private static async Task<bool> ValidateString(string name)
        {
             if (string.IsNullOrEmpty(name))
            {
                return false;
            }else if (name.Contains("{"))
            {
                return false;
            }else if (name.Contains("}"))
            {
                return false;
            }else if (name.Contains("["))
            {
                return false;
            }else if (name.Contains("]"))
            {
                return false;
            }else if (name.Contains("("))
            {
                return false;
            }else if (name.Contains(")"))
            {
                return false;
            }else if (name.Contains("/"))
            {
                return false;
            }else if (name.Contains("\\"))
            {
                return false;
            }else if (name.Contains("|"))
            {
                return false;
            }else if (name.Contains(";"))
            {
                return false;
            }else if (name.Contains(":"))
            {
                return false;
            }else if (name.Contains("<"))
            {
                return false;
            }else if (name.Contains(">"))
            {
                return false;
            }else if (name.Contains(","))
            {
                return false;
            }else if (name.Contains("."))
            {
                return false;
            }else if (name.Contains("?"))
            {
                return false;
            }else if (name.Contains("!"))
            {
                return false;
            }else if (name.Length > 50)
            {
                return false;
            }
             return true;
            
            
        }
        public static async Task<bool> ValidateInt(int number)
        {
            if (number < 0)
            {
                return false;
            } else if (number > 99999999)
            {
                return false;
            }
            return true;
        }
    }
    }

