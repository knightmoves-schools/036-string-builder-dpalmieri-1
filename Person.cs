namespace knightmoves;

public class Person {
   private string firstName;
   private string lastName;

   public Person(string firstName, string lastName){
      this.firstName = firstName;
      this.lastName = lastName;
   }

   // Add your code here
   string BuildFullName(){
      StringBuilder fullName = new StringBuilder($"{firstName}, {lastName}");
      return fullName.ToString();
   }
}
