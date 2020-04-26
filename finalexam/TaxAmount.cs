// using System;
// //Karan Gajjar
// namespace finalexam
// {
//     public class TaxAmount
//     {
//         ProvinceTax provinceTax;
//         public TaxAmount(){

//         }

//         //created SetStrategy to set ProvinceTax class
//         internal void SetStrategy(ProvinceTax provinceTax){
//             this.provinceTax=provinceTax;
//         }

//         //calculate method will simply call initialized provincetax object's CalculateTax method.
//         internal string calculate(double total) {
//             return provinceTax.CalculateTax(total).ToString();
//         }
//     }
// }