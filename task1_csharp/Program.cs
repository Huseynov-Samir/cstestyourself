Console.Write("add your text ");
string? name = Console.ReadLine();
Console.Write("add your number ");
int? age  = Convert.ToInt16(Console.ReadLine());
char addSymbol = '?';

if(name=="g" || age==1){
	name = Console.ReadLine();
	age  = Convert.ToInt16(Console.ReadLine());
	if(name=="admin" && age==12){
		addSymbol='R';
	}
	else{
		addSymbol='A';
		string text= age>30?"yes it is possible":"no it isnt possible";
		Console.WriteLine(text);
	}
}else if(name=="guset" && age==10){
	addSymbol='B';
	age  = Convert.ToInt16(Console.ReadLine());
	switch (age)
	{
		case 10:
			Console.WriteLine("yes is it");
			break;
		case 20:
			Console.WriteLine("nope is it");
			break;
		default:
			Console.WriteLine("wrong");
			break;
	}
}else{
	string typeAge;
	typeAge=age switch
	{
		112 => "add your number but not",
		115 => "add your number but wow",
		_=> "wow",
	};
	Console.WriteLine(typeAge);
	addSymbol='C';
}

Console.WriteLine(name+" "+age+" "+addSymbol);

