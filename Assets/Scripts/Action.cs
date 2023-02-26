using UnityEngine;

static public class Action {
    static public void EscapeAction()
    {
        Debug.Log("Quit");
        // TODO: Application.Quit();
    }

    static public void MovementAction(Entity entity, Vector2 direction)
    {
        // TODO: Debug.Log($"{entity.name} moves {direction}!")
        entity.Move(direction);
        GameManager.instance.EndTurn();
    }

    static public void SkipAction(Entity entity)
    {
        // TODO: Debug.Log($"{entity.name} skipped their turn!")
        GameManager.instance.EndTurn();
    }
}