# Method
### Method is use to perform certain action, they also known as function
### Method is run when it is called

```
public string Greating()
{
  console.writeline("Hello from here");
}

obj.Greating();     #Hello from here
obj.Greating();     #Hello from here
```
# Constructor
### Constructor is like method, but most of the time, constructor use to pass the parameter to the new instant of the class.

```
private float fltLength;
private float fltBreadth;

public Rectangle (float GiveMeTheLength, float GiveMeTheBreadth)
     {
         fltBreadth = GiveMeTheBreadth;
         fltLength = GiveMeTheLength;
     }
static void Main(string[] args)
{
    Obj cat = new Obj(20, 5);		#instantiation new object "cat"
}
```

#### For a method to be qualified as a constructor, it must have the following 3 features:
- The method name must be the same as class name `Cube`
- It returns nothing, We do not specify a void return type `public Cube`
- It must be public    `public`
    
    
```
        class Cube
        {        
	          public Cube(){}
        }
```
    
    
    
    



