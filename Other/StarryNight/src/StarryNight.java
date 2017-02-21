/**
 * Created by arodriguez on 1/17/2017.
 */
import java.applet.*;
import java.util.*;
import java.awt.*;
public class StarryNight extends Applet {
    public static final int WIDTH = 800;
    public static final int HEIGHT = 600;

    public void paint(Graphics g) {
        setSize(WIDTH, HEIGHT);
        setBackground(Color.BLACK);
        setForeground(Color.white);
        g.fillOval(WIDTH / 2, HEIGHT / 2, 40, 40);
    }
}
