﻿using System;

namespace ILenguage.API.Domain.Services.Communications
{
    public abstract class BaseResponse<T>
    {
        public T Resource { get; set; }
        public string Message { get; protected set; }
        public bool Succes { get; set; }


        protected BaseResponse(T resource)
        {
            Resource = resource;
            Succes = true;
            Message = string.Empty;
        }

        protected BaseResponse(string message)
        {
            Succes = false;
            Message = message;
        }
    }
}