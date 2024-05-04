internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu dai: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu rong: ");
        double height = double.Parse(Console.ReadLine());
        Rectangle rec = new Rectangle(width, height);
        Console.WriteLine("Hinh chu nhat: \n" + rec.Display());
        Console.WriteLine("Chu vi hinh chu nhat la: " + rec.getPer());
        Console.WriteLine("Dien tich hinh chu nhat la: " + rec.getArea());
    }
}
public class Rectangle {
    double width, height;
    public Rectangle(double width, double height){
        this.width = width;
        this.height = height;
    }
    public double getArea(){
        return this.width * this.height;
    }
    public double getPer(){
        return (this.width + this.height) * 2;
    }
    public string Display() {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
}