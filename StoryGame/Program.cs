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

void characterL(){
  Raylib.DrawCircle(450,heightY-200,45,Color.BLACK);
}

void characterR(){
  Raylib.DrawCircle(widthX-450, heightY-200,45,Color.BLACK);
}


Raylib.InitWindow(widthX, heightY, "The title of my window");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  
  Raylib.ClearBackground(Color.BLACK);
  

  if(Raylib.IsKeyPressed(KeyboardKey.KEY_A) )
  { 
    choice1();
    choice2();
    characterL();
    
  } else if(Raylib.IsKeyPressed(KeyboardKey.KEY_D) )
  { 
    choice1();
    choice2();
    characterR();
  } else (Raylib.IsKeyPressed(KeyboardKey.KEY_S) )
  {
    choice1();
    choice2();
    character();

  }


  
  Raylib.EndDrawing();
}
