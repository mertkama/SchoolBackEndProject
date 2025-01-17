﻿using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success)
        {
            Success = success;
        }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
