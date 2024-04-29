


public class StoneFalling: GameEvent{
    public StoneFalling(){
        EventName = "StoneFalling";
    }

    public override void Run()
    {
        // Do something
        TutorialGameRunner.Instance.TutorialManager.ActivateTutorAnimationTrigger("Happy");

        // tutor.animator.SetTrigger("StoneFalling");
    }
}