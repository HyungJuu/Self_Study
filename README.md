# Self_Study
개인 복습 리포지토리

## HTML

## WPF
- Event
    - Bubbling(버블링) : 자식에서 부모(상위)로 이벤트 발생
    - Tunneling(터널링) : 부모(상위)에서 자식으로 이벤트 발생
        - 터널링의 이벤트에는 preview가 붙어있다

    - 이벤트 제어 : 더이상 이벤트를 발생시키고 싶지 않을 경우
        ```csharp
        e.Handled = true;
        ```


- Template
    - DataTemplate : 템플릿 모델을 사용해서 데이터 표시를 좀 더 자유롭게(유연하게) 정의할 수 있는 기능

    - ControlTemplate
    - ItemsPanelTemplate
