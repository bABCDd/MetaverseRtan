using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraMiniGame : MonoBehaviour
{
    public Transform target; // 따라갈 타겟을 지정합니다.
    float offsetX; // 타겟과 카메라 사이의 X축 오프셋을 저장합니다.

    // Start is called before the first frame update
    void Start()
    {
        // 타겟이 지정되지 않은 경우, 경고 메시지를 출력합니다.
        if (target == null)
            return;
        // 타겟의 현재 위치를 기준으로 카메라의 X축 오프셋을 계산합니다.
        offsetX = transform.position.x - target.position.x;
        // 카메라의 초기 위치를 타겟의 위치에 오프셋을 적용하여 설정합니다.
    }

    // Update is called once per frame
    void Update()
    {
        // 타겟이 지정되지 않은 경우, 아무 작업도 하지 않습니다.
        if (target == null)
            return;
        // 카메라의 위치를 타겟의 위치에 오프셋을 적용하여 업데이트합니다.
        Vector3 pos = transform.position;
        pos.x = target.position.x + offsetX;
        transform.position = pos;

        // 카메라의 벡터값 변수를 선언. 
    }
}
