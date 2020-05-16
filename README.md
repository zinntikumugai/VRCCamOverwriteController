# VRCCamOverwriteController
Avatarの画像アップロード時の画像にSDKのバージョンやらを追加できる様になるスクリプトです  

![](https://cdn.discordapp.com/attachments/589079124618903553/711114620471083068/unknown.png)
![](https://cdn.discordapp.com/attachments/589079124618903553/711115448023777361/unknown.png)
## 使い方
1. VRCSDKやAvatarなどインポートし、アップロード可能な状態にしておく
1. unitypackageをインポート
1. `zin3Tools/VRCCamOverwrite`の`VRCCOC`プレハブをSceneに追加
1. Scene上の`VRCCOC`オブジェクトを選択し、Inspector上の`VRC Cam Overwrite Controller`の設定
    - View SDK Version: SDKのバージョンを表示
    - View Unity Version: Unityのバージョンを表示
    - Write Texts: 末尾に文字列を追加します
    - Cam Distance: カメラとの距離  
        VRCCamがデフォルトでのおすすめ設定
        - 0.5: Avatarの前あたり
        - 50: Avatarの後ろあたり
    - SDK File Path: SDKのバージョンが書かれたファイルのパス(構造変更している場合は修正してください)
- 文字がかぶるのでVRCCamの高さを修正する
- Build & Publishをする

## その他
やってることとしてはVRCamの前にUIを置いてるだけなので適当な画像を追加するなどもできると思います  
同様のスクリプトとして[VRCCamController](https://github.com/kmnk/VRCCamController)([booth](https://booth.pm/ja/items/1296842)) があります
## License
MIT License
## Update Log
- 1.0 初期リリース
- 1.1 ライセンス周り修正