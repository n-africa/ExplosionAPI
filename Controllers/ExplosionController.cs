using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        public class Digits
        {
            [HttpGet]
            public static string Explode(string s)
            {
                var initialString = "";

                for (var index = 0; index < s.Length; index++)
                {
                    var numberOfCharacter = s[index].ToString();

                    var numbers = Int32.Parse(numberOfCharacter);

                    for (var otherIndex = 0; otherIndex < numbers; otherIndex++)
                    {
                        initialString += numberOfCharacter;
                    }
                }
                return initialString;
            }
        }
        public class Accumul
        {
            [HttpGet]
            public static String Accum(string input)
            {
                var answer = "";
                for (var index = 0; index < input.Length; index++)
                {
                    var currentCharacter = input[index];
                    for (var repeatCount = 0; repeatCount < index + 1; repeatCount++)
                    {
                        if (repeatCount == 0)
                        {
                            answer += Char.ToUpper(currentCharacter);
                        }
                        else
                        {
                            answer += Char.ToLower(currentCharacter);
                        }
                    }
                    if (index < input.Length - 1)
                    {
                        answer += "-";
                    }
                }
                return answer;
            }
        }
    }
}