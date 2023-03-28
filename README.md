# LikesList
A simple C# project that asks the user to input names that like a post and responds accordingly.

## Running
```
dotnet build
dotnet run
```
## Process
* Runs a while loop and asks the user to enter a name or hit Enter
* appends any entered names to a list
* responds who liked your post based on list length

## Output
No names entered: 
```
enter a name or hit ENTER to quit:

```
1 name entered:
```
enter a name or hit ENTER to quit: Mike
enter a name or hit ENTER to quit:
Mike likes your post
```
2 names entered:
```
enter a name or hit ENTER to quit: Mike
enter a name or hit ENTER to quit: John
enter a name or hit ENTER to quit: 
Mike and John like your post
```
\> 2 names entered
```
enter a name or hit ENTER to quit: Mike
enter a name or hit ENTER to quit: John
enter a name or hit ENTER to quit: Dave
enter a name or hit ENTER to quit: Keith
enter a name or hit ENTER to quit: 
Mike, John, and 2 others like your post
```