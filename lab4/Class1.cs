﻿using lab3_;
Vector te=new Vector();
te.Input();
Console.WriteLine("Введите эдемент,который хотите добавить в конец: ");
double El = Convert.ToDouble(Console.ReadLine());
te.last(El);
te.Output();
te.Remove();
Console.WriteLine("Введите индекс и элемент,который вы хотите добавить: ");
int IN = Convert.ToInt32(Console.ReadLine());
double El1 = Convert.ToDouble(Console.ReadLine());
te.insert(IN, El1);
te.Output();
te.delete(IN);
te.Output();
te.DeleteeEL(El);
te.Output();
Console.WriteLine(te.Kol());