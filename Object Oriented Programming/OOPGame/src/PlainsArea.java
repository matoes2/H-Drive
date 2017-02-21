/**
 * Created by arodriguez on 1/23/2017.
 */
import java.util.*;
public class PlainsArea extends Area {
    public PlainsArea(){
        type = "Plains";
        monsterType.add("Coyote");
        monsterType.add("Fox");
        monsterType.add("Bison");
    }
    public Enemy EnemyEncounter(){
        rand = new Random();
        monsterIndex = rand.nextInt(3);
        if(monsterType.get(monsterIndex).equals("Coyote")){
            health = 60;
            strength = 25;
            defense = 50;
        }
        else if(monsterType.get(monsterIndex).equals("Fox")){
            health = 100;
            strength = 100;
            defense = 20;
        }
        else if(monsterType.get(monsterIndex).equals("Bison")) {
            health = 8000;
            strength = 15;
            defense = 100;
        }
        Enemy tempEnemy = new Enemy(health, strength, defense, monsterType.get(monsterIndex));
        return tempEnemy;
    }
}
