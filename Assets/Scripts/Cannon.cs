using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject _fireBall;
    [SerializeField] private Transform _shotPosition;
    [SerializeField] private int _resetShots;
    [SerializeField] private float _resetRechargeTimer;
    [SerializeField] private Color _disabledColor;

    private float rechargeTimer;
    private int shotsBeforeRecharge;
    private SpriteRenderer rend;

    private void Start()
    {
        shotsBeforeRecharge = _resetShots;
        rechargeTimer = _resetRechargeTimer;

        rend = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (rechargeTimer <=0)
        {
            shotsBeforeRecharge = _resetShots;
        }
        if (Input.GetMouseButtonUp(0))
        {
            rechargeTimer = _resetRechargeTimer;
        }
        if (shotsBeforeRecharge > 0)
        {
            rend.color = Color.white;
        }
        else
        {
            rend.color = _disabledColor;
        }
    }

    private void OnMouseDown()
    {
        print("cannon shoot");

        if (shotsBeforeRecharge > 0)
        {

            Instantiate(_fireBall, _shotPosition.position, Quaternion.identity);

            shotsBeforeRecharge--;
        }
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            rechargeTimer -= Time.deltaTime;
        }
    }
}
