using System;
using CSharpOOP3;


#region Ball
Ball ball = new Ball("ball",8.6);
ball.Volume();
ball.PrintInfo();
#endregion

#region Pyramid
Pyramid pyramid = new Pyramid("pyramid", 5.6, 15.4);
pyramid.Volume();
pyramid.PrintInfo();
#endregion

#region Cylinder
Cylinder cylinder = new Cylinder("cylinder",5.7,4.3);
cylinder.Volume();
cylinder.PrintInfo();
#endregion

#region Structure
var student = new Student("Anton", 18);
student.PrintInfo();
#endregion

Console.ReadLine();



