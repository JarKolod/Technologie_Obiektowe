using UnityEngine;

public class SecimenHealthyFragileState : SpecimenState
{

    public override void EnterState( SpecimenMeneger specimentMeneger )
    {
        specimentMeneger.GetComponent<SpriteRenderer>().color = new Color(0,0.4f,0.2f);
    }


    public override void UpdateState( SpecimenMeneger specimentMeneger)
    {
        specimentMeneger.transform.Rotate(Vector3.forward,Random.Range(-20f,20f));
        specimentMeneger.transform.Translate( Vector3.right * specimentMeneger.Speed * Time.deltaTime );
    }

    public override void OnCollisonStay( SpecimenMeneger specimenMeneger , SpecimenMeneger other )
    {
        return;
    }
}
