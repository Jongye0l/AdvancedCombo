# AdvancedCombo
---
### 소개 Information
* 기존과 다른 콤보시스템을 지원합니다.
---
### 사용 방법 How to use
* 오버레이어 GUI에서 모듈을 들어가 AdvancedCombo를 다운로드 한다
---
### 태그 Tag
* GCombo - 초록색 판정까지(정확)에 콤보수
* YCombo - 노란색 판정까지(느림, 정확, 빠름)에 콤보수
* RCombo - 빨간색 판정까지(느림!, 느림, 정확, 빠름, 빠름!)에 콤보수
* ACombo - 자동으로 넘어가는 콤보수
  * GCombo가 끊기면 YCombo로 넘어가고 YCombo가 끊기면 RCombo로 넘어간다.
  * RCombo가 끊기면 다시 GCombo로 넘어간다.(설정 가능)
* AString - 자동으로 넘어가는 콤보수가 어디에 있는 콤보인지의 설정된 텍스트
* AValue - 자동으로 넘어가는 콤보수가 어디에 있는 콤보인지의 값
  * 값 : Green, Yellow, Red
---
### 구성 Config
* 자동플레이 타일로 인한 판정도 콤보에 포함시키기
* 초록, 노란색 콤보가 한번 끊기면 자동 콤보를 무조건 빨간색 콤보로 뜨게 하기
* 자동 콤보가 초록색 콤보일 경우 나올 텍스트
* 자동 콤보가 노란색 콤보일 경우 나올 텍스트
* 자동 콤보가 빨간색 콤보일 경우 나올 텍스트
---
### 개발 환경 Development environment
* Windows 11
* Rider 2023.2.3
* .NET Framework 4.8
* A Dance of Fire and Ice 2.6.3(r120)
* Overlayer 3.0.3
---
### 테스트 환경 Test environment
* Windows 11
* A Dance of Fire and Ice 2.6.3(r120)
* Overlayer 3.0.3
