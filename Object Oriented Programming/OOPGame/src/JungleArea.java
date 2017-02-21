/**
 * Created by arodriguez on 1/23/2017.
 */
import java.util.*;
public class JungleArea extends Area {
    public JungleArea(){
        type = "Jungle";
        monsterType.add(0, "Monkey");
        monsterType.add(1, "Toucan");
        monsterType.add(2, "Poison Dart Frog");
    }
    public Enemy EnemyEncounter(){
        rand = new Random();
        monsterIndex = rand.nextInt(3);
        if(monsterType.get(monsterIndex).equals("Monkey")){
            health = 70;
            strength = 15;
            defense = 25;
        }
        else if(monsterType.get(monsterIndex).equals("Toucan")){
            health = 50;
            strength = 20;
            defense = 5;
        }
        else if(monsterType.get(monsterIndex).equals("Poison Dart Frog")) {
            health = 10;
            strength = 15;
            defense = 10;
        }
        Enemy tempEnemy = new Enemy(health, strength, defense, monsterType.get(monsterIndex));
        return tempEnemy;
    }
}
