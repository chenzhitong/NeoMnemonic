# NeoMnemonic

比特币助记词算法的 C# 实现。

## 方法

生成助记词

[BIP39 Wordlists](https://github.com/bitcoin/bips/blob/master/bip-0039/bip-0039-wordlists.md)

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

> 错误情况：
>
> 1、助记词单词数必须为 12 或 15 或 18 或 21 或 24
>
> 2、助记词必须为助记词列表中的单词
>
> 3、助记词校验不通过

通过种子生成特定币种的私钥

Coin Type: BTC 0, ETH 60, NEO 888, ONT 1024 [完整的币种列表](https://github.com/satoshilabs/slips/blob/master/slip-0044.md)

```
Mnemonic.SeedToWPF(seed, 0);
Mnemonic.SeedToWPF(seed, 888);
Mnemonic.SeedToWPF(seed, 1024);
```

## 示例

```
Mnemonic: test cruise rely brand crazy spoon soda flee congress spawn lady curious
Seed: c7a91f4aa3ace1425881cf36abb74304361e4a22c8ea43af93898d635e3af71f938834279085d7227842af39de613bbc20a34ab5d6bc077de051c53cf909a1ae
BTC WIF: L4E3VT1Nr7NkTJ8ttZ3dQdcGtGHYvw2rByUjEQfGUdvRQAGrpJeq
NEO WIF: L3QZ4s4qgK5ggT2SnPL6nLEdTdhQeogssCgCJmYhDwVneR49MQCD
ONT WIF: KypaagtwRKXNPk1uhsdQ9YGhSTVGsg7aDrs8T76HLjcRnqAj1emb

Mnemonic: cup lens idle rail flash flower large gold super crouch second circle
Seed: 20e5ebc63a1ba7dcd8b3089724220826a74b12b776c5178b0dde9c68f17ccc66b629471a00401c513d2b5102ebed179873ca6ed6ad33b31e34776e2dfabed155
BTC WIF: L14VBFUyPf779ttoBkmJS37d123vHp3oZVu7fWe4HViNceoxqz1p
NEO WIF: L2VpzdAG1Jek5hiALVV51L3mHDtbc4qtDryXxja9yDS4g7X5yepd
ONT WIF: Kzugw7LWBcpiw2PRR8THNrHnzeDXqNScMm2yAdfu59HU9UuPRvAG

Mnemonic: assume violin aware gown patch dry age review chimney pottery proof van
Seed: 8f5e20367352c3585c55f6a92a4a161df9e1d8903269dc3f3643f66da53f2136cc9d864e49b0c43c00539bc2dd9a094d9c61c99ecc4d9248be6473b8df268257
BTC WIF: L5aQxZw1WySvjicid847s2hTfFRoeudSXs3gsxp1CszUZLrHa2RK
NEO WIF: Ky72nn6F7kJGj5Dcm69BbAKC2L3D8iMZYns2AYaP5iNAqCULXMq7
ONT WIF: L5Ax3gvY8mVyj69pHj24g2BCk5sqcG1ncdZFj3GpuvFDUw8u7uUF
```

## 参考：

[BIP39](https://github.com/bitcoin/bips/blob/master/bip-0039.mediawiki)

[BIP32](https://github.com/bitcoin/bips/blob/master/bip-0032.mediawiki)

[BIP43](https://github.com/bitcoin/bips/blob/master/bip-0043.mediawiki)

[BIP44](https://github.com/bitcoin/bips/blob/master/bip-0044.mediawiki)

[比特币源码学习-钱包标准(一)-BIP32/BIP44](https://blog.csdn.net/m0_37847176/article/details/82011876)

[比特币源码学习-钱包标准（二）-BIP39](https://blog.csdn.net/m0_37847176/article/details/82177627)

[助记词 - 廖雪峰的官方网站](https://www.liaoxuefeng.com/wiki/1207298049439968/1207320517404448)

[理解开发HD 钱包涉及的 BIP32、BIP44、BIP39](https://learnblockchain.cn/2018/09/28/hdwallet/)

[基于 BIP-32 和 BIP-39 规范生成 HD 钱包（分层确定性钱包）](https://stevenocean.github.io/2018/09/23/generate-hd-wallet-by-bip39.html)