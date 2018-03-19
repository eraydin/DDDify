namespace DDDify.FSharp.Bus    

open System    

type Event =
   | When of DateTime
   interface IMessage 