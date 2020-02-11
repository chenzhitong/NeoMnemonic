# NeoMnemonic

比特币助词词 BIP39 的 C# 实现，代码精简，去除了对比特币的偶合；
与 Neo 松耦合，仅在 Sha256 和 导出私钥两处进行了引用。

## 方法

生成助记词

```csharp
Mnemonic.GenerateMnemonic();

Mnemonic.GenerateMnemonic(EntropyLength._128)

Mnemonic.GenerateMnemonic(EntropyLength._128, Mnemonic.Language.ChineseSimplified)
```

通过助记词和口令（可选）生成种子

```csharp
Mnemonic.MnemonicToSeed(words);

Mnemonic.MnemonicToSeed(words, "passphrase");
```

## 示例

```
Mnemonic: layer cute chase green east silent comfort pulse never obey fragile average
WIF: L2T74AZUAs8qKYGercUub7ex1JgfY53G2hQ2xBDuXFAF8oMNiTgC

Mnemonic: rich mobile chair arrange often describe execute settle journey arena peanut sudden
WIF: L4HdQSpu1TmTmVKzMpR3gTFwibjuPLNz5DFFck2kJvngHZP7gTK7

Mnemonic: area poet follow gain heart swear brief cloud north two heavy fade
WIF: L3jwtQQWuBkaHvvp3gdv7u2PJpknYE8mo9VCiZUcKrdR7ik5mdbM

Mnemonic: country alone offer moment laundry inspire master tone shop cluster torch flag
WIF: KyWQP2byVT53iKQ6TmnCaqpR8k5MURvMQz6QPK4XPzdfxSGNTJnw
```

```
Mnemonic: 如 连 实 算 价 印 远 悬 妥 查 动 徙
WIF: L1Ejs1XhrevX16Erhdp19nX63XE4CXNcaaMEvYHYw2VEVq3zE6DQ

Mnemonic: 门 卡 验 争 笼 府 鼓 执 薄 了 伦 邮
WIF: KwYMAfhUZgEWdABPJdKvbmqDWY27qWT7BTeL23XCxqiDgGMpBPU7

Mnemonic: 却 敬 股 写 功 牵 盐 互 顾 院 坡 乌
WIF: Ky6XLDXPVF7BCFPkicGGCgf7A25bHfrZurDB1hzxL5Zeg4ZWKLTj
```

```
Mnemonic: 臣 叔 戶 胺 倉 遇 鉺 軟 均 杭 伴 前 竟 須 婦 蔣 勞 聯 鹼 訟 運 林 衡 殖
WIF: KwUFHWnYktEqxMiUsem4iQXBfb1Z7KwK4DPDABTMsxLGnNDBdn8P

Mnemonic: 為 貿 望 怎 柬 徹 罷 誠 惜 噴 焰 刑 坐 寫 款 飯 奮 鍵 田 覽 傳 雲 環 虎
WIF: KxUPkv14MkiF9iF7UZ1Ec2vGtRqQ8YVN1dxoBxgmzcarGs82rNqH

Mnemonic: 罪 粒 順 雨 憂 難 洲 徒 偏 爭 授 倉 壁 府 巧 屈 植 舞 之 下 像 逆 忘 朝
WIF: KzDRYmGEmqR61NWBpaVCX1DJVU8UB5g2vbsNstDRK6a3AGVHfZxG
```

## 参考：

BIP39

https://github.com/bitcoin/bips/blob/master/bip-0039.mediawiki

BIP39 Wordlists

https://github.com/bitcoin/bips/blob/master/bip-0039/bip-0039-wordlists.md

BIP39.NET

https://github.com/realindiahotel/BIP39.NET

比特币源码学习-钱包标准(一)-BIP32/BIP44

https://blog.csdn.net/m0_37847176/article/details/82011876

比特币源码学习-钱包标准（二）-BIP39

https://blog.csdn.net/m0_37847176/article/details/82177627

助记词 - 廖雪峰的官方网站

https://www.liaoxuefeng.com/wiki/1207298049439968/1207320517404448

JavaScript implementation of Bitcoin BIP39

https://github.com/bitcoinjs/bip39

理解开发HD 钱包涉及的 BIP32、BIP44、BIP39

https://learnblockchain.cn/2018/09/28/hdwallet/

基于 BIP-32 和 BIP-39 规范生成 HD 钱包（分层确定性钱包）

https://stevenocean.github.io/2018/09/23/generate-hd-wallet-by-bip39.html