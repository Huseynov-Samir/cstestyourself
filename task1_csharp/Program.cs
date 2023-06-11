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
}else{
	addSymbol='C';
}

Console.WriteLine(name+" "+age+" "+addSymbol);