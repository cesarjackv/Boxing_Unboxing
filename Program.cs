List<object> obj = new List<object>();
obj.Add(7);
obj.Add(28);
obj.Add(-1);
obj.Add(true);
obj.Add("chair");

int sum = 0;

foreach(object item in obj){
    Console.WriteLine(item);
    if(item is int){
        sum += (int)item;
    }
}

Console.WriteLine(sum);