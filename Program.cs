// MoneyCollector Class
class VendingMachine {

  // Public Fields
  private int moneyCollected;
  private int productPrice;
  private int insertedMoney;


  // Parameter-less Constructor to intialize the vending machine object
  public VendingMachine() { 
    this.moneyCollected = 0;
    this.productPrice = 2; // Let's fix the product price to 2$
    this.insertedMoney = 0;
  }

  public void AddMoney(int money) { // Method to add money to collection
    this.insertedMoney = money;
    if (this.insertedMoney >= 0) {  // Check if the customer inserted valid money
      Console.WriteLine("You inserted Rs{0}",this.insertedMoney);
      this.Change(); // Call the change method to provide change
    }
    else Console.WriteLine("Invalid Insertion");
    // as a good practice set inserted to 0 at the end of transaction
    this.insertedMoney = 0;
  }

  private void Change() { //method to provide change
    if (this.insertedMoney >= this.productPrice) { //check if any change
      int change = this.insertedMoney-this.productPrice; //calculate change
      this.moneyCollected += this.productPrice; // Add money to total collection
      Console.WriteLine("Your change is: Rs{0}",change);
    }
    else {
      Console.WriteLine("You didn't insert sufficient money!");
      // Return whatever the user entered
      Console.WriteLine("Your change is: Rs{0}",this.insertedMoney);
    }
  }

  public int GetMoneyCollected() { // Getter to moneyCollected
    return this.moneyCollected;
  }

}

class Demo {

  public static void Main(string[] args) {
    // Create a new money collector object
    var vendingMachine = new VendingMachine();
    // 3 Customers purchase products
    vendingMachine.AddMoney(3);
    vendingMachine.AddMoney(5);
    vendingMachine.AddMoney(7);
    // getting the collected as 3 products sold it should be 2*3 = 6
    Console.WriteLine("Total collection till now is: Rs{0}",vendingMachine.GetMoneyCollected());

    // Uncommenting the below line will now cause an error
    //moneyCollector.moneyCollected = 20;

  }

}