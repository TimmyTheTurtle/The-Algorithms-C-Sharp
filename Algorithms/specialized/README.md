# Specialized Algorithms - Domain-Specific & Cutting-Edge

Welcome to **Specialized Algorithms**! These are algorithms used in specific domains—cryptography, financial computing, machine learning, and recommendation systems. Unlike the CS 100-400 level hierarchy (based on computer science curriculum), specialized algorithms are organized by **field/domain** rather than difficulty.

## 📚 Learning Objectives

By completing this section, you will understand:
- **Cryptography**: Hash functions, digest algorithms, padding schemes
- **Financial Computing**: Time value of money, present value calculations
- **Machine Learning**: Regression, classification, and similarity-based learning
- **Recommender Systems**: Collaborative filtering and similarity metrics
- Practical applications of algorithms in real-world domains
- When and why to use domain-specific algorithms

## ⚠️ Prerequisites

**Before diving into specialized algorithms:**
- Understanding of **Linear Algebra** is helpful (especially for ML)
- Basic **Statistics** concepts (mean, variance, distance metrics)
- All **300-level algorithms** recommended (especially math algorithms)
- For Crypto: Understanding of **Number Theory** and **Modular Arithmetic**
- For MachineLearning: Comfort with **Matrix operations**

---

## 🎯 Recommended Learning Path

### Phase 1: Cryptography Fundamentals (Foundations of Security)

Cryptography is about secure communication and data protection. Start with basic concepts before implementing.

#### 1.1 Hash Functions & Digests

Hash functions produce fixed-size outputs from variable-size inputs. Essential for security.

- [ ] [**IDigest Interface** - Digest Contract](./Crypto/Digests/IDigest.cs) - Base interface for all hash functions
- [ ] [**Md2Digest** - MD2 Hash](./Crypto/Digests/Md2Digest.cs) - Historical (128-bit), deprecated
- [ ] [**AsconDigest** - ASCON Hash](./Crypto/Digests/AsconDigest.cs) - Lightweight authenticated encryption

**Time to spend**: 1-1.5 hours  
**Key Takeaway**: Hash functions are deterministic, fixed-output functions; slight input change = completely different output  
**Real-world use**: Password storage, data integrity verification, blockchain  
**Warning**: MD2 is deprecated; use SHA-256 or better in production  

#### 1.2 Padding Schemes

Padding ensures data is properly sized for block ciphers. Without it, some plaintext lengths would fail.

- [ ] [**IBlockCipherPadding Interface** - Padding Contract](./Crypto/Paddings/IBlockCipherPadding.cs) - Base for all padding schemes
- [ ] [**Pkcs7Padding** - PKCS#7 Padding](./Crypto/Paddings/Pkcs7Padding.cs) - Most common, simple, effective
- [ ] [**Iso7816D4Padding** - ISO 7816-4 Padding](./Crypto/Paddings/Iso7816D4Padding.cs) - Standard for ISO systems
- [ ] [**Iso10126D2Padding** - ISO 10126-2 Padding](./Crypto/Paddings/Iso10126D2Padding.cs) - With random bytes
- [ ] [**TbcPadding** - Trailing Bit Complement Padding](./Crypto/Paddings/TbcPadding.cs) - TBC method
- [ ] [**X932Padding** - X9.23 Padding](./Crypto/Paddings/X932Padding.cs) - X9.23 standard

**Time to spend**: 1 hour  
**Key Takeaway**: Padding adds predictable bytes; receiver removes them after decryption  
**Critical Concept**: Padding oracle attacks (security vulnerability if validation is weak)  
**Note**: Use authenticated encryption (like AES-GCM) instead of padding + unencrypted mode  

#### 1.3 Cryptographic Utilities

Support functions for cryptographic operations.

- [ ] [**ByteEncodingUtils** - Byte Operations](./Crypto/Utils/ByteEncodingUtils.cs) - Convert between formats
- [ ] [**LongUtils** - Long Integer Operations](./Crypto/Utils/LongUtils.cs) - Multi-precision support
- [ ] [**ValidationUtils** - Validation Helpers](./Crypto/Utils/ValidationUtils.cs) - Input validation for crypto

**Time to spend**: 0.5 hours  
**Key Takeaway**: Cryptographic utilities handle tedious but critical operations  

---

### Phase 2: Financial Algorithms (Time Value of Money)

Financial algorithms deal with money over time—a crucial concept in finance.

- [ ] [**PresentValue** - Calculate Present Value](./PresentValue.cs) - What is future money worth today?

**Time to spend**: 0.5 hours  
**Key Takeaway**: PV = FV / (1 + r)^n - discount future value back to present  
**Real-world use**: Investment analysis, loan evaluation, retirement planning  
**Example**: Is $1000 today worth more than $1100 next year? Depends on interest rate!  
**Complexity**: O(1) for single calculation, O(n) for series  

---

### Phase 3: Machine Learning Fundamentals

Machine learning algorithms learn patterns from data. This is an introduction to basic ML.

#### 3.1 Regression (Predicting Continuous Values)

- [ ] [**LinearRegression** - Simple Linear Regression](./MachineLearning/LinearRegression.cs) - Fit a line to data
- [ ] [**LogisticRegression** - Logistic Regression](./MachineLearning/LogisticRegression.cs) - Classification using sigmoid

**Time to spend**: 1.5-2 hours  
**Prerequisite**: Understand matrix operations, calculus (derivatives)  
**Key Takeaway**: 
- **Linear**: Fits a line (y = mx + b) to minimize error
- **Logistic**: Uses sigmoid function for binary classification
**Real-world use**:
- Linear: House price prediction, demand forecasting
- Logistic: Spam detection, disease diagnosis
**Complexity**: Training is O(n×m) for n samples, m features  

#### 3.2 Classification (Categorical Prediction)

- [ ] [**KNearestNeighbors** - K-Nearest Neighbors](./MachineLearning/KNearestNeighbors.cs) - Lazy learning, simple classification

**Time to spend**: 1 hour  
**Key Takeaway**: Find k nearest points; vote on their labels  
**Real-world use**: Recommendation systems, pattern recognition  
**Complexity**: O(n×m) at prediction time (lazy learner)  
**Warning**: KNN is slow on large datasets; consider faster approaches  

---

### Phase 4: Recommender Systems (Personalization)

Recommender systems predict user preferences. Essential for modern applications.

- [ ] [**ISimilarityCalculator Interface** - Similarity Contract](./RecommenderSystem/ISimilarityCalculator.cs) - Base for similarity metrics
- [ ] [**CollaborativeFiltering** - CF Recommendation](./RecommenderSystem/CollaborativeFiltering.cs) - User-user or item-item similarity

**Time to spend**: 1-1.5 hours  
**Prerequisite**: Similarity metrics (cosine, Euclidean), matrix operations  
**Key Takeaway**: Recommend based on similar users' preferences  
**Real-world use**:
- Netflix movie recommendations
- Amazon product recommendations
- Spotify playlist suggestions
**Complexity**: O(n×m) for similarity matrix, O(m log m) for top-k selection  
**Types of CF**:
- **User-User**: Find similar users, recommend what they liked
- **Item-Item**: Find similar items, recommend based on liked items
- **Matrix Factorization**: Decompose user-item matrix into latent factors

---

## 🏆 Mastery Checklist - By Domain

### Cryptography Mastery
- [ ] Can explain difference between hash functions and encryption
- [ ] Understand why padding is needed
- [ ] Know which padding scheme to use when
- [ ] Understand basic crypto attacks (padding oracle, birthday attacks)
- [ ] Can implement a simple hash function

### Financial Mastery
- [ ] Understand time value of money
- [ ] Can calculate present value for various interest rates
- [ ] Understand compound interest
- [ ] Know how to evaluate investment decisions

### Machine Learning Mastery
- [ ] Can explain linear regression mathematically
- [ ] Understand how logistic regression differs from linear
- [ ] Know how to evaluate model performance
- [ ] Can implement KNN from scratch
- [ ] Understand overfitting and underfitting

### Recommender Systems Mastery
- [ ] Understand collaborative filtering
- [ ] Know different similarity metrics
- [ ] Can implement basic CF system
- [ ] Understand cold-start problem
- [ ] Know limitations of CF (data sparsity, scalability)

---

## 💡 Key Concepts by Domain

### Cryptography
**Security Through Obscurity is Ineffective**: Security comes from mathematics, not secrecy  
**Key Management**: The hardest part of cryptography (not the algorithm itself)  
**Always Use Industry Standards**: Don't roll your own crypto  
**Authenticated Encryption**: Encrypt + Sign (or use AES-GCM)  

### Financial
**Time Value of Money**: Central concept in finance  
**Discount Rate**: Reflects risk and opportunity cost  
**Compound Growth**: Exponential growth over time  

### Machine Learning
**Train/Test Split**: Evaluate on unseen data  
**Overfitting**: Model memorizes instead of generalizes  
**Feature Scaling**: Normalize features for better convergence  
**Bias-Variance Tradeoff**: Simple models vs. complex models  

### Recommender Systems
**Collaborative Filtering**: Assumes similar users like similar items  
**Cold Start Problem**: New users/items have no data  
**Data Sparsity**: Most user-item pairs are unknown  
**Scalability**: Computing similarity for millions of users is hard  

---

## 📊 Complexity Summary

| Algorithm | Time | Space | Domain |
|-----------|------|-------|--------|
| MD2 Hash | O(n) | O(1) | Crypto |
| ASCON Hash | O(n) | O(1) | Crypto |
| Padding | O(n) | O(1) | Crypto |
| Present Value | O(1) | O(1) | Finance |
| Linear Regression | O(n×m) | O(m) | ML |
| Logistic Regression | O(n×m) | O(m) | ML |
| K-Nearest Neighbors | O(n×m) | O(n) | ML |
| Collaborative Filtering | O(u×i) | O(u×i) | RecSys |

*n = data points, m = features, u = users, i = items*

---

## 🚀 Real-World Applications

### Cryptography
- **HTTPS Certificates**: Use SHA-256 hashes
- **Blockchain**: Bitcoin uses SHA-256 repeatedly
- **Password Hashing**: bcrypt, scrypt, Argon2 (specialized hash functions)
- **VPNs & TLS**: Essential for secure communication

### Financial
- **Investment Analysis**: Present value of stock cash flows
- **Loan Pricing**: Calculate effective interest rates
- **Retirement Planning**: How much to save monthly
- **Valuation Models**: DCF (Discounted Cash Flow) analysis

### Machine Learning
- **Predictive Analytics**: Forecast sales, demand, trends
- **Classification**: Email spam, image recognition, medical diagnosis
- **Anomaly Detection**: Fraud detection, outlier identification
- **Natural Language Processing**: Sentiment analysis, text classification

### Recommender Systems
- **E-commerce**: Amazon, Alibaba product recommendations
- **Streaming**: Netflix, Spotify playlist suggestions
- **Social Networks**: LinkedIn connection recommendations
- **News/Content**: Personalized news feeds, article suggestions

---

## ⚠️ Important Warnings

### Cryptography
- **NEVER use MD2 or MD5 in production** - Cryptographically broken
- **NEVER implement your own crypto** - Use established libraries
- **ALWAYS use authenticated encryption** - Encryption alone doesn't guarantee integrity
- **ALWAYS salt hashes** - Rainbow tables attack unsalted hashes
- **Key rotation is important** - Periodically refresh cryptographic keys

### Machine Learning
- **NEVER use ML for high-stakes decisions without human review** - Can perpetuate bias
- **ALWAYS check for data leakage** - Information from test set in training causes false accuracy
- **Train on representative data** - Biased data produces biased models
- **Feature importance matters** - Not all features contribute equally

### Recommender Systems
- **Filter bubbles**: Users only see similar content (can radicalize)
- **Cold start problem**: New users/items hard to recommend
- **Popularity bias**: Popular items recommended too much
- **Privacy concerns**: CF requires storing user behavior data

---

## 🎓 Further Study Paths

### Deep Cryptography
- Study AES, RSA, ECC encryption algorithms
- Understand public-key cryptography
- Learn about digital signatures
- Study cryptographic protocols

### Advanced Machine Learning
- Deep Learning (neural networks)
- Ensemble methods (random forests, gradient boosting)
- Support vector machines
- Probabilistic models

### Recommender Systems
- Matrix factorization techniques
- Deep learning for recommendations
- Context-aware recommendations
- Multi-armed bandit algorithms

---

## 🔗 Resources by Domain

### Cryptography
- [NIST Cryptographic Standards](https://csrc.nist.gov/projects/cryptographic-standards-and-guidelines/)
- [Cryptography I - Stanford (Coursera)](https://www.coursera.org/learn/crypto)

### Finance
- [Time Value of Money - Khan Academy](https://www.khanacademy.org/economics-finance-domain/core-finance)
- [Corporate Finance - Wharton on Coursera](https://www.coursera.org/learn/corporate-finance)

### Machine Learning
- [Machine Learning - Andrew Ng (Coursera)](https://www.coursera.org/learn/machine-learning)
- [Scikit-learn Documentation](https://scikit-learn.org/)

### Recommender Systems
- [Recommender Systems Specialization - University of Minnesota](https://www.coursera.org/specializations/recommender-systems)
- [Papers on Collaborative Filtering](https://dl.acm.org/journal/tosn)

---

## 💪 Challenge Projects

Once you're comfortable with specialized algorithms, try these:

1. **Build a Movie Recommender**: Implement CF with MovieLens dataset
2. **Crypto Weak Password Detector**: Estimate password strength
3. **Stock Price Predictor**: Use linear/logistic regression on stock data
4. **Fraud Detection System**: ML classifier for credit card fraud
5. **Personalized News Feed**: Recommend news articles using CF

---

## 📝 Summary

Specialized algorithms tackle **domain-specific problems** that aren't covered by general CS curriculum:
- **Cryptography** keeps data secure and private
- **Financial algorithms** handle money and time
- **Machine Learning** finds patterns in data
- **Recommender Systems** personalize user experiences

These algorithms are staples in modern software engineering, and understanding them deeply will make you a more versatile engineer. Start with the foundations (crypto digests, linear regression), then build to more complex systems.

---

**Start with Cryptography Fundamentals, then move to your domain of interest. Each domain builds different skills! 🚀**
