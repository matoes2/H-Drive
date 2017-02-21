/**
 * Created by arodriguez on 1/23/2017.
 */
import java.util.*;
public class FrostArea extends Area {
    public FrostArea(){
        type = "Frost";
        monsterType.add("Articuno");
        monsterType.add("Falling Icicle");
        monsterType.add("Frost Giant");
    }
    public Enemy EnemyEncounter(){
        rand = new Random();
        monsterIndex = rand.nextInt(3);
        if(monsterType.get(monsterIndex).equals("Articuno")){
            health = 90;
            strength = 40;
            defense = 50;
        }
        else if(monsterType.get(monsterIndex).equals("Falling Icicle")){
            health = 10;
            strength = 500;
            defense = 2000;
        }
        else if(monsterType.get(monsterIndex).equals("Frost Giant")) {
            health = 10000;
            strength = 80;
            defense = 200;
        }
        Enemy tempEnemy = new Enemy(health, strength, defense, monsterType.get(monsterIndex));
        return tempEnemy;
    }
}
