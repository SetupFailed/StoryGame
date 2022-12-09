using Raylib_cs;

int widthX = 1600;
int heightY = 900;



void choice1(){
  Raylib.DrawCircle(450,heightY-200,75,Color.WHITE);
}

void choice2(){
  Raylib.DrawCircle(widthX-450, heightY-200,75,Color.WHITE);
}

void character(){
  Raylib.DrawCircle(widthX/2,heightY-200,30,Color.WHITE);
}



Raylib.InitWindow(widthX, heightY, "The title of my window");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  
  Raylib.ClearBackground(Color.BLACK);
  
  character();

  choice1();
  choice2();

  if(Raylib.IsKeyPressed(KeyboardKey.KEY_A) )
  {
    
  }
  
  
  Raylib.EndDrawing();
}
