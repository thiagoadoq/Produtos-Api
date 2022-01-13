﻿using System.Collections.Generic;
using System.Linq;

namespace Corporate.Havan.Schedule.Domain.Commons
{
    public class BaseResult
    {
        public BaseResult()
        {

        }

        public BaseResult(string error)
        {
            Erros = new List<string> { error };
        }

        public BaseResult(List<string> errors)
        {
            Erros = errors;
        }

        public static List<string> Erros { get; set; }
        public bool IsValid() => Erros.Any();

        protected static void AddMessageError(string message) 
        {
            if (Erros == null)
                Erros = new List<string>();
            Erros.Add(message);
        } 
    }
}
