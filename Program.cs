global using System;
global using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

namespace RayInput;

public struct DisplayKey
{
    public WinVirtualKey Key;
    public Vector2 Position;
    public Vector2 Size;
    public Texture2D Texture;

}

public class Program
{
    public static void Main(string[] args)
    {
        Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_RESIZABLE);
        Raylib.SetConfigFlags(ConfigFlags.FLAG_WINDOW_TRANSPARENT);

        Raylib.InitWindow(400, 200, "RayInputDisplay");

        #region KeyBuilding

        List<DisplayKey> keys = new List<DisplayKey>();

        DisplayKey a = new DisplayKey();
        a.Key = WinVirtualKey.VK_A;
        a.Position = new Vector2(0, 72);
        a.Size = new Vector2(32, 32);
        Image aImage = Raylib.LoadImage("Images/a.png");
        a.Texture = Raylib.LoadTextureFromImage(aImage);
        Raylib.UnloadImage(aImage);

        DisplayKey b = new DisplayKey();
        b.Key = WinVirtualKey.VK_B;
        b.Position = new Vector2(144, 108);
        b.Size = new Vector2(32, 32);
        Image bImage = Raylib.LoadImage("Images/b.png");
        b.Texture = Raylib.LoadTextureFromImage(bImage);
        Raylib.UnloadImage(bImage);

        DisplayKey c = new DisplayKey();
        c.Key = WinVirtualKey.VK_C;
        c.Position = new Vector2(72, 108);
        c.Size = new Vector2(32, 32);
        Image cImage = Raylib.LoadImage("Images/c.png");
        c.Texture = Raylib.LoadTextureFromImage(cImage);
        Raylib.UnloadImage(cImage);

        DisplayKey d = new DisplayKey();
        d.Key = WinVirtualKey.VK_D;
        d.Position = new Vector2(72, 72);
        d.Size = new Vector2(32, 32);
        Image dImage = Raylib.LoadImage("Images/d.png");
        d.Texture = Raylib.LoadTextureFromImage(dImage);
        Raylib.UnloadImage(dImage);

        DisplayKey e = new DisplayKey();
        e.Key = WinVirtualKey.VK_E;
        e.Position = new Vector2(72, 36);
        e.Size = new Vector2(32, 32);
        Image eImage = Raylib.LoadImage("Images/e.png");
        e.Texture = Raylib.LoadTextureFromImage(eImage);
        Raylib.UnloadImage(eImage);

        DisplayKey f = new DisplayKey();
        f.Key = WinVirtualKey.VK_F;
        f.Position = new Vector2(108, 72);
        f.Size = new Vector2(32, 32);
        Image fImage = Raylib.LoadImage("Images/f.png");
        f.Texture = Raylib.LoadTextureFromImage(fImage);
        Raylib.UnloadImage(fImage);

        DisplayKey g = new DisplayKey();
        g.Key = WinVirtualKey.VK_G;
        g.Position = new Vector2(144, 72);
        g.Size = new Vector2(32, 32);
        Image gImage = Raylib.LoadImage("Images/g.png");
        g.Texture = Raylib.LoadTextureFromImage(gImage);
        Raylib.UnloadImage(gImage);

        DisplayKey n = new DisplayKey();
        n.Key = WinVirtualKey.VK_N;
        n.Position = new Vector2(180, 108);
        n.Size = new Vector2(32, 32);
        Image nImage = Raylib.LoadImage("Images/n.png");
        n.Texture = Raylib.LoadTextureFromImage(nImage);
        Raylib.UnloadImage(nImage);

        DisplayKey q = new DisplayKey();
        q.Key = WinVirtualKey.VK_Q;
        q.Position = new Vector2(0, 36);
        q.Size = new Vector2(32, 32);
        Image qImage = Raylib.LoadImage("Images/q.png");
        q.Texture = Raylib.LoadTextureFromImage(qImage);
        Raylib.UnloadImage(qImage);

        DisplayKey r = new DisplayKey();
        r.Key = WinVirtualKey.VK_R;
        r.Position = new Vector2(108, 36);
        r.Size = new Vector2(32, 32);
        Image rImage = Raylib.LoadImage("Images/r.png");
        r.Texture = Raylib.LoadTextureFromImage(rImage);
        Raylib.UnloadImage(rImage);

        DisplayKey s = new DisplayKey();
        s.Key = WinVirtualKey.VK_S;
        s.Position = new Vector2(36, 72);
        s.Size = new Vector2(32, 32);
        Image sImage = Raylib.LoadImage("Images/s.png");
        s.Texture = Raylib.LoadTextureFromImage(sImage);
        Raylib.UnloadImage(sImage);

        DisplayKey v = new DisplayKey();
        v.Key = WinVirtualKey.VK_V;
        v.Position = new Vector2(108, 108);
        v.Size = new Vector2(32, 32);
        Image vImage = Raylib.LoadImage("Images/v.png");
        v.Texture = Raylib.LoadTextureFromImage(vImage);
        Raylib.UnloadImage(vImage);

        DisplayKey w = new DisplayKey();
        w.Key = WinVirtualKey.VK_W;
        w.Position = new Vector2(36, 36);
        w.Size = new Vector2(32, 32);
        Image wImage = Raylib.LoadImage("Images/w.png");
        w.Texture = Raylib.LoadTextureFromImage(wImage);
        Raylib.UnloadImage(wImage);

        DisplayKey three = new DisplayKey();
        three.Key = WinVirtualKey.VK_THREE;
        three.Position = new Vector2(72, 0);
        three.Size = new Vector2(32, 32);
        Image threeImage = Raylib.LoadImage("Images/3.png");
        three.Texture = Raylib.LoadTextureFromImage(threeImage);
        Raylib.UnloadImage(threeImage);

        DisplayKey four = new DisplayKey();
        four.Key = WinVirtualKey.VK_FOUR;
        four.Position = new Vector2(108, 0);
        four.Size = new Vector2(32, 32);
        Image fourImage = Raylib.LoadImage("Images/4.png");
        four.Texture = Raylib.LoadTextureFromImage(fourImage);
        Raylib.UnloadImage(fourImage);

        DisplayKey shift = new DisplayKey();
        shift.Key = WinVirtualKey.VK_LSHIFT;
        shift.Position = new Vector2(0, 108);
        shift.Size = new Vector2(64, 32);
        Image shiftImage = Raylib.LoadImage("Images/shift.png");
        shift.Texture = Raylib.LoadTextureFromImage(shiftImage);
        Raylib.UnloadImage(shiftImage);

        DisplayKey ctrl = new DisplayKey();
        ctrl.Key = WinVirtualKey.VK_LCONTROL;
        ctrl.Position = new Vector2(0, 144);
        ctrl.Size = new Vector2(64, 32);
        Image ctrlImage = Raylib.LoadImage("Images/ctrl.png");
        ctrl.Texture = Raylib.LoadTextureFromImage(ctrlImage);
        Raylib.UnloadImage(ctrlImage);

        DisplayKey spacebar = new DisplayKey();
        spacebar.Key = WinVirtualKey.VK_SPACE;
        spacebar.Position = new Vector2(68, 144);
        spacebar.Size = new Vector2(128, 32);
        Image spacebarImage = Raylib.LoadImage("Images/spacebar.png");
        spacebar.Texture = Raylib.LoadTextureFromImage(spacebarImage);
        Raylib.UnloadImage(spacebarImage);

        DisplayKey mouseL = new DisplayKey();
        mouseL.Key = WinVirtualKey.VK_LBUTTON;
        mouseL.Position = new Vector2(234, 0);
        mouseL.Size = new Vector2(32, 48);
        Image mouseLImage = Raylib.LoadImage("Images/mouseL.png");
        mouseL.Texture = Raylib.LoadTextureFromImage(mouseLImage);
        Raylib.UnloadImage(mouseLImage);

        DisplayKey mouseR = new DisplayKey();
        mouseR.Key = WinVirtualKey.VK_RBUTTON;
        mouseR.Position = new Vector2(282, 0);
        mouseR.Size = new Vector2(32, 48);
        Image mouseRImage = Raylib.LoadImage("Images/mouseR.png");
        mouseR.Texture = Raylib.LoadTextureFromImage(mouseRImage);
        Raylib.UnloadImage(mouseRImage);

        DisplayKey mouseW = new DisplayKey();
        mouseW.Key = WinVirtualKey.VK_MBUTTON;
        mouseW.Position = new Vector2(266, 2);
        mouseW.Size = new Vector2(16, 46);
        Image mouseWImage = Raylib.LoadImage("Images/mouseW.png");
        mouseW.Texture = Raylib.LoadTextureFromImage(mouseWImage);
        Raylib.UnloadImage(mouseWImage);

        DisplayKey mouseX1 = new DisplayKey();
        mouseX1.Key = WinVirtualKey.VK_XBUTTON1;
        mouseX1.Position = new Vector2(236, 48);
        mouseX1.Size = new Vector2(16, 32);
        Image mouseX1Image = Raylib.LoadImage("Images/mouseX.png");
        mouseX1.Texture = Raylib.LoadTextureFromImage(mouseX1Image);
        Raylib.UnloadImage(mouseX1Image);

        DisplayKey mouseX2 = new DisplayKey();
        mouseX2.Key = WinVirtualKey.VK_XBUTTON2;
        mouseX2.Position = new Vector2(236, 80);
        mouseX2.Size = new Vector2(16, 32);
        Image mouseX2Image = Raylib.LoadImage("Images/mouseX.png");
        mouseX2.Texture = Raylib.LoadTextureFromImage(mouseX2Image);
        Raylib.UnloadImage(mouseX2Image);

        keys.Add(a);
        keys.Add(b);
        keys.Add(c);
        keys.Add(d);
        keys.Add(e);
        keys.Add(f);
        keys.Add(g);
        keys.Add(n);
        keys.Add(q);
        keys.Add(r);
        keys.Add(s);
        keys.Add(v);
        keys.Add(w);
        keys.Add(three);
        keys.Add(four);
        keys.Add(shift);
        keys.Add(ctrl);
        keys.Add(spacebar);
        keys.Add(mouseL);
        keys.Add(mouseR);
        keys.Add(mouseW);
        keys.Add(mouseX1);
        keys.Add(mouseX2);

        Console.WriteLine("Image loading phase 1 complete");

        for (int i = 0; i < keys.Count; i++)
        {
            DisplayKey key = keys[i];
            key.Texture.width = (int)keys[i].Size.X;
            key.Texture.height = (int)keys[i].Size.Y;
            keys[i] = key;
        }


        Texture2D mouseBG = Raylib.LoadTextureFromImage(Raylib.LoadImage("Images/mouseBG.png"));
        Vector2 mouseBGpos = new Vector2(234, 0);

        Console.WriteLine("Image loading phase 2 complete");

        #endregion

        byte globalOpacity = 255;

        Color keyBackground = ColorB(150, 150, 150, globalOpacity);
        Color keyBackgroundActive = ColorB(240, 240, 240, globalOpacity);

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.GREEN);

            Raylib.DrawTextureV(mouseBG, mouseBGpos, Color.WHITE);

            for (int i = 0; i < keys.Count; ++i)
            {
                if (Inputs.GetKey(keys[i].Key))
                {
                    Raylib.DrawRectangleV(keys[i].Position, keys[i].Size, keyBackgroundActive);
                    Raylib.DrawTextureV(keys[i].Texture, keys[i].Position, Color.BLACK);
                }
                else
                {
                    Raylib.DrawRectangleV(keys[i].Position, keys[i].Size, keyBackground);
                    Raylib.DrawTextureV(keys[i].Texture, keys[i].Position, Color.WHITE);
                }
            }

            Raylib.EndDrawing();
        }
    }

    public static Color ColorB(byte r, byte g, byte b, byte a)
    {
        return new Color(r, g, b, a);
    }
}