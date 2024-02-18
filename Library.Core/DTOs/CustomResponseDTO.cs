using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace Library.Core.DTOs
{
    public class CustomResponseDTO<T>
    {
        public T Data { get; set; }

        //bu proprtynin jsona döndürülmemesini belirttik çünkü zaten clientler istek attıklarında status kodu zaten otomatik olarak alıyorlar ama bize kod içerisinde lazım olduğu için bunu kullandık
        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<string> Errors { get; set; }


        public static CustomResponseDTO<T> Success(int statusCode, T data)
        {
            return new CustomResponseDTO<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomResponseDTO<T> Success(int statusCode)
        {
            return new CustomResponseDTO<T> {StatusCode = statusCode };
        }  
        public static CustomResponseDTO<T> Fail(int statusCode,List<string> errors)
        {
            return new CustomResponseDTO<T> {StatusCode = statusCode,Errors=errors };
        }  
        public static CustomResponseDTO<T> Fail(int statusCode,string error)
        {
            return new CustomResponseDTO<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
