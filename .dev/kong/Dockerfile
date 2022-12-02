FROM debian AS extras

ADD https://github.com/kreuzwerker/envplate/releases/download/v1.0.2/envplate_1.0.2_Linux_x86_64.tar.gz /tmp

WORKDIR /tmp

RUN \
tar zxfv envplate_1.0.2_Linux_x86_64.tar.gz; \
ls -la /tmp; \
mv envplate ep; mv ep /usr/local/bin/

FROM kong:3.0

USER root

COPY --from=extras /usr/local/bin/ep /usr/local/bin
COPY .dev/kong/docker-entrypoint.sh /docker-entrypoint.sh
RUN \
echo '_format_version: "1.1"' > /kong.yml; \
chmod a+x /docker-entrypoint.sh;

USER kong

