/**
 * Created by arodriguez on 1/23/2017.
 */
import java.util.*;
public class DesertArea extends Area{
    public DesertArea(){
        type = "Desert";
        monsterType.add("Desert Eagle");
        monsterType.add("Cactus");
        monsterType.add("Clint Eastwood");
    }
    public Enemy EnemyEncounter(){
        rand = new Random();
        monsterIndex = rand.nextInt(3);

        if(monsterType.get(monsterIndex).equals("Desert Eagle")){
            health = 80;
            strength = 15;
            defense = 25;
        }
        else if(monsterType.get(monsterIndex).equals("Cactus")){
            health = 10;
            strength = 15;
            defense = 40;
        }
        else if(monsterType.get(monsterIndex).equals("Clint Eastwood")) {
            health = 100;
            strength = 95;
            defense = 10;
        }
        Enemy tempEnemy = new Enemy(health, strength, defense, monsterType.get(monsterIndex));
        return tempEnemy;
    }
}
