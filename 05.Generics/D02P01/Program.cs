﻿using D02P01;

string[] strings = ArrayCreator.Create(5, "Pesho");
int[] integers = ArrayCreator.Create(10, 33);

Console.WriteLine(string.Join(", ", strings));
Console.WriteLine(string.Join(", ", integers));
