// using System;

// namespace finalexam
// {
//     public class EmployeeGroup : Component
//     {
//         private List<Component> _children = new List<Component>();
//         public EmployeeGroup(){

//         }
//         public void AddComponent(Component component)
//         {
//             this._children.Add(component);
//         }
//         internal override void Display() {
//             Console.WriteLine($"Employee Name: {component}; Performance Rating : {component}");
 
//       // Recursively display child nodes
//       foreach (Component component in _children)
//       {
//         component.Display();
//       }
//         }
//     }
// }