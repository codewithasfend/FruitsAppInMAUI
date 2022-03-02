namespace FruitsApp;

public partial class MainPage : ContentPage
{
    List<Fruit> fruitsList = new List<Fruit>()
    {
           new Fruit(){ Name="Apple",ImageName="apple.png",Sentence="Did you taste my mother's apple cookies? This is the best cookie you can eat in the world."},
           new Fruit(){ Name="Apricot",ImageName="apricot.png",Sentence="We had apricot trees in the back and side yard of the property."},
           new Fruit(){ Name="Banana",ImageName="banana.png",Sentence="When I was a child, I thought that monkeys do not eat anything but the banana."},
           new Fruit(){ Name="Coconut",ImageName="coconut.png",Sentence="I am watching this Survivor show on TV. How can a person feel full by only eating coconuts?"},
           new Fruit(){ Name="Grape",ImageName="grape.png",Sentence="I really do not like grapes if they are not seedless."},
           new Fruit(){ Name="Guava",ImageName="guava.png",Sentence="On either side of the road are groves of guava trees."},
           new Fruit(){ Name="Kiwi",ImageName="kiwi.png",Sentence="It was a very funny episode of Friends that Monica makes Ross eat kiwifruit which he is allergic to.."},
           new Fruit(){ Name="Mango",ImageName="mango.png",Sentence="My brother loves drinking mango juice."},
           new Fruit(){ Name="Melon",ImageName="melon.png",Sentence="The best fruit to eat in the summertime is honey melon."},
           new Fruit(){ Name="Orange",ImageName="orange.png",Sentence="You should consume some healthy food also. What about eating an orange?"},
           new Fruit(){ Name="Peach",ImageName="peach.png",Sentence="Although my mom cannot touch peaches, she washed and sliced peach for me."},
           new Fruit(){ Name="Pear",ImageName="pear.png",Sentence="There is a saying in Turkish: ‘The best pear is eaten by bears.’"},
           new Fruit(){ Name="Pineapple",ImageName="pineapple.png",Sentence="It was a mystery that how that pineapple came to the student center without nobody moving it."},
           new Fruit(){ Name="Plum",ImageName="plum.png",Sentence="I really want to eat some plums, but I guess we cannot find any in this season."},
           new Fruit(){ Name="Pomegranate",ImageName="pomegranate.png",Sentence="Even though I love pomegranate, it is very difficult to prepare it to eat."},
           new Fruit(){ Name="Strawberry",ImageName="strawberry.png",Sentence="Emma does not love yogurt itself, but she eats strawberry yogurt every day."},
           new Fruit(){ Name="Watermelon",ImageName="watermelon.png",Sentence="My favorite summer fruit is watermelon, I love eating it when it is cold."},
    };
    public MainPage()
    {
        InitializeComponent();
         LvFruits.ItemsSource = fruitsList;
    }

   

    private void LvFruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selecteditem = e.SelectedItem as Fruit;
        Navigation.PushAsync(new FruitDetailPage(selecteditem));
    }
}

