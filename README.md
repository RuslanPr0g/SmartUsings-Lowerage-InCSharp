# Using keyword
Provides a convenient syntax that ensures the correct use of IDisposable objects. Beginning in C# 8.0, the using statement ensures the correct use of IAsyncDisposable objects.  Also lowering CODE is present here :)

# Code lowering
Lowering One semantic technique that is obvious in hindsight (but took Andrei Alexandrescu to point out to me) is called 'lowering' It consists of, internally, rewriting more complex semantic constructs in terms of simpler ones. For example, while loops and foreach loops can be rewritten in terms of for loops. Then, the rest of the code only has to deal with for loops. This turned out to uncover a couple of latent bugs in how while loops were implemented in D, and so was a nice win. It's also used to rewrite scope guard statements in terms of try-finally statements, etc. Every case where this can be found in the semantic processing will be win for the implementation.
