using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScale : EnemyBase
{
    [Header ("Enemy Scale")]
    public float scale = 1.5f;
    public float duration = 1f;
    public float durationfor = 100f;

    [Space()]
    public MeshRenderer meshRenderer;

    private bool _attacking = false;
    private Coroutine _currentCoroutine;

    public override void Attack()
    {
        base.Attack();

        if(!_attacking)
        {
            _attacking = true;
            transform.localScale *= scale;
            StartCoroutine(ChangeColorCoroutine());
            //ChangeColor();
        }
    }

    public void ResetScale()
    {
        transform.localScale = Vector3.one;
        _attacking = false;
    }

    public override void OnDamage()
    {
        base.OnDamage();
        if (_currentCoroutine == null)
        {
            _currentCoroutine = StartCoroutine(ChangeColorCoroutine());
        }
    }

    IEnumerator DelayCall()
    {
        yield return new WaitForSeconds(duration);

        transform.localScale *= scale;

        yield return new WaitForSeconds(duration);

        transform.localScale = Vector3.one;
        _attacking = false;
    }
    private void ChangeColor()
    {
        for(float i = 1f; i >= 0; i -= .05f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
        }
    }

    IEnumerator ChangeColorCoroutine()
    {
        for (float i = 1f; i >= 0; i -= .05f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, enemyData.colorDamageable, 1 - i));
            yield return new WaitForEndOfFrame();
        }
        yield return new WaitForSeconds(.1f);

        for (float i = 1f; i >= 0; i -= .05f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.red, Color.yellow, 1 - i));
            yield return new WaitForEndOfFrame();
        }
    }
}
