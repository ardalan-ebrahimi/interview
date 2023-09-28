int x = 10;
int y = 20;

int abc(int p, int q) {
    return p + q;
}

int Calculate(int a, int b) {
    return a + b;
}

void ProcessItems(List<object> items) {
    for (int i = 0; i < items.Count; i++) {
        if (items[i] is int) {
            items[i] = (int)items[i] + 10;
        } else if (items[i] is double) {
            items[i] = (double)items[i] - 5.0;
        } else if (items[i] is string) {
            items[i] = ((string)items[i]).ToUpper();
        }
    }
}

class Customer {
    private string Name;
    private int Age;

    public Customer(string name, int age) {
        Name = name;
        Age = age;
    }

    public string GetName() {
        return $"{Name} is {Age} years old.";
    }
}

double Divide(double a, double b) {
    if (b == 0) {
        return double.NaN; 
    }
    return a / b;
}
