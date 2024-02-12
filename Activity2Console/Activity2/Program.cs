// See https://aka.ms/new-console-template for more information


Console.Write("Enter length (in centimeters) >>>");

double lengthInCm = Convert.ToInt32(Console.ReadLine());
double inchPerCm = (lengthInCm * 0.39370079);

//int inch = Convert.ToInt32(inchPerCm);

double yardPerInch = (inchPerCm * 0.02777778);

int yards = Convert.ToInt32(yardPerInch);

double remainingYards = (yardPerInch - yards);

double ftPerYards = (remainingYards * 3);

int ft = Convert.ToInt32(ftPerYards);

double remainingFt = (ftPerYards - ft);

double inchPerFt = (remainingFt * 12);

int inch = Convert.ToInt32(inchPerFt);

Console.WriteLine(yards + " yards, " + ft + " feet (foot), " + inch + " inches");
