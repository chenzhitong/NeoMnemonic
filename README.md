# NeoMnemonic

比特币助词词 BIP39 的 C# 实现，代码精简，去除了对比特币的偶合；
与 Neo 松耦合，仅在 Sha256 和 导出私钥两处进行了引用。

方法：

生成助记词

Mnemonic.GenerateMnemonic();

通过助记词和口令（可选）生成种子

Mnemonic.MnemonicToSeed(words);

示例如下：

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