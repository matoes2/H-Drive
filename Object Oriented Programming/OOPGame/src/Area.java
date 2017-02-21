import java.util.ArrayList;
import java.util.Random;

/**
 * Created by arodriguez on 1/24/2017.
 */
public class Area {
    public String type;
    public ArrayList<String> monsterType = new ArrayList<String>();
    public Random rand;
    public int monsterIndex;
    public int health;
    public int strength;
    public int defense;
    public Area(){
    }
    public Enemy EnemyEncounter(){
        return new Enemy(0, 0, 0, "Dad");
    }
}
