
/*•	
	
•	

	
	
	
*/

/*1.Write a program to calculate volume area of swing pool which leant, breath and high 12, 6, 3.
int l = 12;
int b = 6;
int h = 3;
float volume;
volume = l * b * h;
Console.WriteLine(volume);*/



/*2.Wap a program to convert temperature in f in c(F=1.8 c=32
Console.WriteLine("enter the temperature");
int Ftemp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ftemp);
int c = 32 * Ftemp;
Console.WriteLine(c);*/

/*
	Wap asking Nepali Currency Rs. And Convert in to dollar.(72nrs.=1us)
Console.WriteLine("enter the Nepali Currency:");
int NCurr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NCurr);
int DCurr = NCurr/72;
Console.WriteLine("Dollar ="+DCurr ); 
*/

/*Write a program to find out area of a pie (A=πr^2)
 * Console.WriteLine("Area of Pie ");
double  f = Convert.ToDouble( Console.ReadLine());
double area = 3.14 * f * f;
Console.WriteLine(area);
	*/

/*Check the number in odd and even
Console.WriteLine("Enter the number:");
int num =Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
	Console.WriteLine("Even Number ");
}
else
{
	Console.WriteLine("Odd number");
}*/

/*//Find the max among three different numbers.

Console.WriteLine("Enter first number: ");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second  number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1>num2 && num1 > num3)
{
	Console.WriteLine(num1+" is largest");
}
else if(num2>num1 && num2>num3)
{
	Console.WriteLine(num2+ "is Largest ");
}
else
{
	Console.WriteLine(num3 + "is greatest number");
}
*/
/*•	Write a program to find out (a+b)2 ,(a2 + b2)…..*/
/*Console.WriteLine("Enter first number: ");
	int a = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter  number: ");
	int b = Convert.ToInt32(Console.ReadLine());
	int c = (a + b) * (a + b);
	int d = (a* a)+ (b* b);
	Console.WriteLine("(a+b)2 ="+c);
	Console.WriteLine("(a2 + b2)"+d);	*/

//Wap a program to find out total whose marks (name,class,roll,math,science,English,health,social)

/*Console.Write("Enter the number of students:");
int num =Convert.ToInt32(Console.ReadLine());
string[] name = new string[num];
int[] Roll =new int[num];
int[] Class = new int[num];
int[] math = new int[num];
int[] English = new int[num];
int[] Sci= new int[num];
int[] Total = new int[num]; 

for (int i = 0; i < num; i++)
	{
		Console.Write("Enter name" +(i+1)+":" );
		name[i] = Console.ReadLine();

		Console.Write("Enter Roll:");
		Roll[i] = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter Class :");
		Class[i] = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter Marks:- ");

		Console.Write(" Math:");
		math[i]  = Convert.ToInt32(Console.ReadLine());

		Console.Write(" English:");
		English[i] = Convert.ToInt32(Console.ReadLine());

		Console.Write(" Science:");
		Sci[i] = Convert.ToInt32(Console.ReadLine());

		Total[i] = math[i] + English[i] + Sci[i];


	}

Console.WriteLine("Name" + "\t" + "Roll" + "\t" + "Class" + "\t" + "Math" + "\t" + "English"  +"\t"+ "Science" + "\t " + "Total Marks");

for (int i = 0; i < num; i++)
{
	Console.WriteLine(name[i]+"\t"+Roll[i]+ "\t" +Class[i]+ "\t" + math[i]+ "\t" + English[i]+"\t"+ Sci[i] + "\t "+ Total[i] );

}
*/
/*
Write a program to find out the total amount for tickets of a Cinema hall if number of people are given, Rates of tickets are given below:
Tickets Rate
Dress Circle   Rs.50
Balcony        Rs.40
First Class    Rs.30
Second Class   Rs.20
Third Class    Rs.15*/
/*
Console.Write("Total Number of Tickets:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your choice :");
Console.WriteLine(" Choice No.\t Seats \t\t\t Price \n 1 \t\tDress Circle\t\tRs.50 \n 2\t\tBalcony\t\t\tRs.40 \n 3 \t\tFirst class\t\tRs.30 \n 4 \t\tSecond Class\t\tRs.20  \n 5 \t\tThird Class\t\tRs.15 ");
int choice =Convert.ToInt32(Console.ReadLine());

switch (choice)
{
	case 1:
		Console.WriteLine("Dress Circle ");
		int Cprice = num * 50;
		Console.WriteLine("Total : "+Cprice);

		break;
	case 2:
		Console.WriteLine("Balcony");
		int Bprice = num * 40;
		Console.WriteLine("Total : " + Bprice);
		break;
	case 3:
		Console.WriteLine("First Class");
		int Fprice = num * 30;
		Console.WriteLine("Total : " + Fprice);
		break;
	case 4:
		Console.WriteLine("Second Class ");
		int Sprice = num * 20;
		Console.WriteLine("Total : " + Sprice);
		break;
	case 5:
		Console.WriteLine("Third Class");
		int Tprice = num * 15;
		Console.WriteLine("Total : " + Tprice);
		break;
	default:
		Console.WriteLine("Out of choice");
		break;

}*/



int custid, conu;
   double chg, surchg=0, gramt,netamt;
   string connm;

           Console.Write("\n\n");
           Console.Write("Calculate Electricity Bill:\n");
           Console.Write("----------------------------");
           Console.Write("\n\n");

   Console.Write("Input Customer ID :");
   custid= Convert.ToInt32(Console.ReadLine());
   Console.Write("Input the name of the customer :");
   connm= Console.ReadLine();
   Console.Write("Input the unit consumed by the customer : ");
   conu= Convert.ToInt32(Console.ReadLine());
   if (conu <200 )
	chg = 1.20;
   else	if (conu>=200 && conu<400)
		chg = 1.50;
	else if (conu>=400 && conu<600)
			chg = 1.80;
		else
			chg = 2.00;
   gramt = conu*chg;
   if (gramt>300)
	surchg = gramt*15/100.0;
   netamt = gramt+surchg;
   if (netamt  < 100)
	netamt =100;
   Console.Write("\nElectricity Bill\n");
   Console.Write("Customer IDNO                       :{0}\n",custid);
   Console.Write("Customer Name                       :{0}\n",connm);
   Console.Write("unit Consumed                       :{0}\n",conu);
   Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n",chg,gramt);
   Console.Write("Surchage Amount                     :{0}\n",surchg);
   Console.Write("Net Amount Paid By the Customer     :{0}\n",netamt);
}  
} 







